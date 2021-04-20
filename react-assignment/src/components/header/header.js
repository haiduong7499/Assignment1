import React from "react";
import { Button } from "reactstrap";

export default function Header(props) {
  return (
    <div className="clearfix">
      <div className="float-left">
        <img src="./logo.png" alt="" />
      </div>
      <Button color="danger" className="float-right">
        Sign Out
      </Button>
    </div>
  );
}