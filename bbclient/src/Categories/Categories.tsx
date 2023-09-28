import React, { useState, useEffect } from 'react';

import {
	AiFillCaretDown,
    AiFillCaretRight
} from "react-icons/ai";

interface ListItem {
    id: number;
    name: string;
    subCategories?: SubCategory[];
}

interface SubCategory {
    id: number;
    name: string;
    interiorCategories?: ListItem[];
}

interface InteriorCategory {
    id: number;
    name: string;
}

interface ListProps {
  items: ListItem[];
}

const List: React.FC<ListProps> = () => {

    const [items, setItems] = useState<ListItem[]>([]); // Estado para almacenar los datos
    const [loading, setLoading] = useState(true)

    useEffect(() => {
        // Realiza una solicitud HTTP para obtener los datos desde el endpoint
        fetch('https://localhost:44365/ManageCategory/categories')
          .then(response => response.json())
          .then(data => {
            setItems([]);
            setItems(data); // Establece los datos en el estado
            setLoading(false); // Indica que la carga ha terminado
          })
          .catch(error => {
            console.error('Error al obtener los datos:', error);
            setLoading(false); // Indica que la carga ha terminado
          });
      }, []);
     
      
  const [selectedItem, setSelectedItem] = useState<ListItem | null>(null);

  const handleEdit = (item: ListItem) => {
    // Lógica para editar el ítem aquí
    console.log('Editar:', item);
  };

  const handleDelete = (item: ListItem) => {
    // Lógica para eliminar el ítem aquí
    console.log('Eliminar:', item);
  };

  const toggleSubitems = (item: ListItem) => {
    setSelectedItem(selectedItem === item ? null : item);
  };
  console.log(items);
  return (
    <div>
        <div>
            <h1>Manage Categories</h1>
        </div>
  
        <div className="container">
            <div className="row">
                <div className="col-md-6">
                <div className="dropdown">
                    <button
                    className="btn btn-secondary dropdown-toggle"
                    type="button"
                    id="dropdownMenuButton"
                    data-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                    >
                    Selecciona una opción
                    </button>
                    <div className="dropdown-menu" aria-labelledby="dropdownMenuButton">
                    <a className="dropdown-item" href="#">
                        Opción 1
                    </a>
                    <a className="dropdown-item" href="#">
                        Opción 2
                    </a>
                    <a className="dropdown-item" href="#">
                        Opción 3
                    </a>
                    </div>
                </div>
                </div>
                <div className="col-md-6">
                <button className="btn btn-success mr-2">Agregar 1</button>
                <button className="btn btn-success mr-2">Agregar 2</button>
                <button className="btn btn-success">Agregar 3</button>
                </div>
            </div>
            </div>  
        <div>
        <ul className="list-group">
        {loading ? <p>loading</p> : items.map((item) => (
            <li key={item.id} className="list-group-item">
            <div className="d-flex justify-content-between align-items-center">
                
                { item.subCategories && item.subCategories?.length >0 ?  
            
                <button
                    className="btn btn-secondary"
                    onClick={() => toggleSubitems(item)}
                    >
                    
                    {selectedItem === item ? <AiFillCaretDown /> : <AiFillCaretRight />} 
                </button>
                
                : <span></span>}
            
                {item.name}
                <div>
                <button
                    className="btn btn-primary mr-2"
                    onClick={() => handleEdit(item)}
                >
                    Editar
                </button>
                <button
                    className="btn btn-danger mr-2"
                    onClick={() => handleDelete(item)}
                >
                    Eliminar
                </button>
                
                </div>
            </div>
            {selectedItem === item && item.subCategories && (
                <ul className="list-group mt-2">
                {item.subCategories.map((subCategories) => (
                    <li key={subCategories.id.toString() + 'A'} className="list-group-item">
                    <div className="d-flex justify-content-between align-items-center">
                        {subCategories.name}
                        <div>
                        <button
                            className="btn btn-primary mr-2"
                            onClick={() => handleEdit(item)}
                        >
                            Editar
                        </button>
                        <button
                            className="btn btn-danger"
                            onClick={() => handleDelete(item)}
                        >
                            Eliminar
                        </button>
                        </div>
                    </div>
                    </li>
                ))}
                </ul>
            )}
            </li>
        ))}
        </ul> 
        </div>
        
    </div>
    
  );
};

// Datos de ejemplo (dummy data)
const dummyData: ListProps = {
  items: [
    {
        id: 1000,
        name: 'Marketing',
        subCategories: [
        { id: 101, name: 'SubItem 1.1' },
        { id: 102, name: 'SubItem 1.2' },
      ],
    },
    {
        id: 2000,
        name: 'Postcards',
        subCategories: [
        { id: 201, name: 'SubItem 2.1' },
        { id: 202, name: 'SubItem 2.2' },
      ],
    },
    {
        id: 3000,
        name: 'Facebook'
      },
  ],
};

export default () => <List items={[]} />;