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
    <form onSubmit={formik.handleSubmit}>
      <label htmlFor="username">Gebruikersnaam</label>
      <input
        type="text"
        name="username"
        id="username"
        onChange={formik.handleChange}
        value={formik.values.username}
      />
      <label htmlFor="password">Wachtwoord</label>
      <input
        type="password"
        name="password"
        id="password"
        onChange={formik.handleChange}
        value={formik.values.password}
      />
      <button type="submit">Submit</button>
    </form>
  );
}

export default Login;
