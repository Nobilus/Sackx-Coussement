import React, { FunctionComponent } from "react";

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
      <a className="px-2">
        <Link href="/klanten">klanten</Link>
      </a>
    </footer>
  );
};

export default Footer;
