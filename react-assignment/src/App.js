import React from 'react';
import NavbarComponent from './components/header/navbar-component.js';
import PageLayout from './components/pagelayout/pagelayout.js';
import Routes from './routes.js'
import { BrowserRouter as Router } from "react-router-dom";
function App() {
  return (
    <Router>
      <PageLayout header={<NavbarComponent />} content={<Routes/>}></PageLayout>
    </Router>
  );
}

export default App;
