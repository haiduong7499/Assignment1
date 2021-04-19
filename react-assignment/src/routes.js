import React from "react";
import { Switch, Route } from "react-router-dom";
//page comp
import Dashboard from "./pages/dashboard.js";
import Products from "./pages/products.js";
import Category from "./pages/categories.js";
import Users from "./pages/users.js";
import NotMatch from "./pages/notmatch.js";

export default function Routes(props) {
  return (
    <Switch>
      <Route exact path="/">
        <Dashboard />
      </Route>
      <Route path="/products">
        <Products />
      </Route>
      <Route path="/categories">
        <Category />
      </Route>
      <Route path="/users">
        <Users />
      </Route>
      <Route path="*">
        <NotMatch />
      </Route>
    </Switch>
  );
}