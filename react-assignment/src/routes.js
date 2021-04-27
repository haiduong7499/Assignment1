import React from "react";
import { Switch, Route } from "react-router-dom";
//page comp
import Dashboard from "./pages/dashboard.js";
import Products from "./products/products_page.js";
import Category from "./categories/categories_page.js";
import Users from "./users/users_page.js";
import NotMatch from "./pages/notmatch.js";
import CreateProduct from './products/createproduct_form.js';
import CreateCategory from './categories/createcategory_form';
export default function Routes(props) {
  return (
    <Switch>
      <Route exact path="/">
        <Dashboard />
      </Route>
      <Route path="/products_page">
        <Products />
      </Route>
      <Route path="/categories">
        <Category />
      </Route>
      <Route path="/users">
        <Users />
      </Route>
      <Route path="/createproduct_form/:id">
        <CreateProduct />
      </Route>
      <Route path="/createproduct_form">
        <CreateProduct />
      </Route>
      <Route path="/createcategory_form">
        <CreateCategory />
      </Route>
      <Route path="*">
        <NotMatch />
      </Route>
    </Switch>
  );
}