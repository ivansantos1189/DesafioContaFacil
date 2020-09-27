import axios from "axios";

const api = axios.create({
  baseURL: "https://sdocs.safeweb.com.br/APIMobile/",
});

export default api;
