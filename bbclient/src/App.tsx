import React from 'react';
import logo from './logo.svg';
import './App.css';
import  Sidebar from './Sidebar/Sidebar';
import TableWithSubitems from './Categories/Categories';
import { GlobalStyle } from "./styles/global";
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";

function App() {
  return (
    <div className="container-fluid">
      <div className="row">
        <nav id="sidebar" className="col-md-3 col-lg-2 d-md-block bg-light sidebar">
          <Sidebar />
        </nav>

        <main role="main" className="col-md-9 ml-sm-auto col-lg-10 px-md-4">
        <BrowserRouter>
          <Routes>
            <Route path="categories" element={<TableWithSubitems />}>
              
              {/* <Route path="blogs" element={<TableWithSubitems />} /> */}
            </Route>
          </Routes>
        </BrowserRouter>
        </main>
      </div>
    </div>
  );
}

export default App;
