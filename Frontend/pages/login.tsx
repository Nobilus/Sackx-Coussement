import React from "react";
import Image from "next/image";
import { useFormik } from "formik";

import Logo from "../public/logo.png";

function Login() {
  const formik = useFormik({
    initialValues: { username: "", password: "" },
    onSubmit: (values) => {
      alert(JSON.stringify(values, null, 2));
    },
  });
  return (
    <section className="flex h-screen flex-col justify-center items-center">
      {/* <Image src={Logo} alt="Logo" className="mx-auto" /> */}
      <form
        className="flex flex-col p-4 bg-white m-5 rounded shadow-sm px-10"
        onSubmit={formik.handleSubmit}
      >
        <div className="relative my-4">
          <input
            className="peer border border-green-100 rounded placeholder-transparent pl-0.5 outline-none h-8"
            type="text"
            name="username"
            id="username"
            onChange={formik.handleChange}
            value={formik.values.username}
            placeholder="Gebruikersnaam"
          />
          <label
            htmlFor="username"
            className="cursor-text absolute left-0 -top-4 text-gray-600 text-sm peer-placeholder-shown:left-1  peer-placeholder-shown:text-gray-400 peer-placeholder-shown:top-1 transition-all peer-focus:-top-4 peer-focus:text-gray-600 peer-focus:text-sm text-gray-100"
          >
            Gebruikersnaam
          </label>
        </div>
        <div className="relative my-4">
          <input
            className="peer border border-green-100 rounded placeholder-transparent pl-0.5 outline-none h-8"
            type="password"
            name="password"
            id="password"
            onChange={formik.handleChange}
            value={formik.values.password}
            placeholder="Wachtwoord"
          />
          <label
            className="cursor-text absolute left-0 -top-4 text-gray-600 text-sm peer-placeholder-shown:left-1  peer-placeholder-shown:text-gray-400 peer-placeholder-shown:top-1 transition-all peer-focus:-top-4 peer-focus:text-gray-600 peer-focus:text-sm text-gray-100"
            htmlFor="password"
          >
            Wachtwoord
          </label>
        </div>
        <button
          className="text-white bg-green-100 hover:bg-green-500 px-4 py-2 rounded max-w-max mx-auto"
          type="submit"
        >
          Login
        </button>
      </form>
    </section>
  );
}

export default Login;
