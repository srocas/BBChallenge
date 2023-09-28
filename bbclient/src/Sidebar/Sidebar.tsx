import React from 'react';


function Sidebar() {
    return (
        <nav id="sidebar" className="bg-light">
        <div className="sidebar-header">
            <h3>BB Challenge</h3>
        </div>
    
        <ul className="list-unstyled components">
            <li>
            <a href="/">Home</a>
            </li>
            <li>
            <a href="/content">Content</a>
            </li>
            <li>
            <a href="/admincontent">Manage Content</a>
            </li>
            <li>
            <a href="/categories">Manage Categories</a>
            </li>
        </ul>
        </nav>
    );
    }


export default Sidebar;