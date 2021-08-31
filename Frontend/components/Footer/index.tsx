import React, { FunctionComponent } from "react";
import Customer from "../../public/assets/Customer.svg";
import Trunks from "../../public/assets/Trunks.svg";
import Bestelbonnen from "../../public/assets/Bestelbonnen.svg";

import Link from "next/link";
import { useRouter } from "next/router";

const Footer: FunctionComponent = () => {
  const { pathname } = useRouter();

  function isActive(routename: string) {
    if (pathname !== routename) {
      return false;
    } else {
      return true;
    }
  }

  return (
    <footer className="fixed float-left bottom-0 left-0 w-full bg-white flex flex-row justify-center items-center ">
      <Link href="/">
        <a className="flex flex-col content-center m-auto">
          {/* <Trunks fill={isActive("producten") ? "#00371C" : "#668776"} /> */}

          <p className="m-auto">Producten</p>
        </a>
      </Link>

      <Link href="/bestelbonnen">
        <a className="flex flex-col content-center m-auto">
          {/* <Bestelbonnen
            fill={isActive("bestelbonnen") ? "#00371C" : "#668776"}
          /> */}
          <p className="m-auto">Bestelbonnen</p>
        </a>
      </Link>

      <Link href="/klanten">
        <a className="flex flex-col content-center m-auto">
          {/* <Customer fill={isActive("klanten") ? "#00371C" : "#668776"} /> */}
          <p className="m-auto">Klanten</p>
        </a>
      </Link>
    </footer>
  );
};

export default Footer;
