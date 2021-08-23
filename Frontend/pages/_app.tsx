import "../styles/globals.css";
import type { AppProps } from "next/app";
import { ThemeProvider } from "next-themes";
import React, { useState } from "react";
import Footer from "../components/Footer";
import Login from "./login";

function MyApp({ Component, pageProps }: AppProps) {
  const [isLoggedin, setIsLoggedin] = useState(true);
  return (
    <ThemeProvider attribute="class">
      {isLoggedin ? (
        <>
          <Component {...pageProps} />
          <Footer />
        </>
      ) : (
        <Login />
      )}
    </ThemeProvider>
  );
}
export default MyApp;
