import React, { FunctionComponent } from "react";
import Customer from "../../public/assets/Customer.svg";
import Trunk from "../../public/assets/Trunk.svg";
import Image from "next/image";

import Link from "next/link";
import { useRouter } from "next/router";

const Footer: FunctionComponent = () => {
  const { pathname } = useRouter();

  return (
    <footer className="h-10 bg-white flex flex-row justify-center items-center">
      <a className="px-2">
        <Link href="/producten">producten</Link>
      </a>
      <a className="px-2">
        <Link href="/bestelbonnen">bestelbonnen</Link>
      </a>
      <Link href="/klanten">
        <a>
          <Image src={Customer} alt="klanten" />
          <p>Klanten</p>
        </a>
      </Link>
    </footer>
  );
};

export default Footer;
