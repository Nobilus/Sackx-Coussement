import React from "react";
import { useFormik } from "formik";

function Login() {
  const formik = useFormik({
    initialValues: { username: "", password: "" },
    onSubmit: (values) => {
      alert(JSON.stringify(values, null, 2));
    },
  });
  return (
    <section className="flex h-screen flex-col justify-center items-center">
      <form
        className="flex flex-col p-4 bg-white m-5 rounded shadow-sm px-10"
        onSubmit={formik.handleSubmit}
      >
        <div className="relative my-4">
          <input
            className="peer border-2 border-green-500 rounded placeholder-transparent pl-0.5 outline-none"
            type="text"
            name="username"
            id="username"
            onChange={formik.handleChange}
            value={formik.values.username}
            placeholder="Gebruikersnaam"
          />
          <label
            htmlFor="username"
            className="cursor-text absolute left-0 top-0 -top-4 text-gray-600 text-sm peer-placeholder-shown:top-1 peer-placeholder-shown:left-1  peer-placeholder-shown:text-gray-400 peer-placeholder-shown:top-2 transition-all"
          >
            Gebruikersnaam
          </label>
        </div>
        <div className="relative my-4">
          <input
            className="peer border-2 border-green-500 rounded placeholder-transparent pl-0.5 outline-none"
            type="password"
            name="password"
            id="password"
            onChange={formik.handleChange}
            value={formik.values.password}
            placeholder="Wachtwoord"
          />
          <label
            className="cursor-text absolute left-0 top-0 -top-4 text-gray-600 text-sm peer-placeholder-shown:top-1 peer-placeholder-shown:left-1  peer-placeholder-shown:text-gray-400 peer-placeholder-shown:top-2 transition-all"
            htmlFor="password"
          >
            Wachtwoord
          </label>
        </div>
        <button
          className="text-white bg-green-700 hover:bg-green-900 px-4 py-2 rounded max-w-max mx-auto"
          type="submit"
        >
          Login
        </button>
      </form>
    </section>
  );
}

export default Login;
