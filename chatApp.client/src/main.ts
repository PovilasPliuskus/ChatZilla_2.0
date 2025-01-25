import { createApp } from "vue";
import "../src/styles/style.css";
import App from "./App.vue";
import { plugin, defaultConfig } from "@formkit/vue";
import "@formkit/themes/genesis";
import "bootstrap/dist/css/bootstrap.min.css";

const app = createApp(App);

app.use(plugin, defaultConfig);

app.mount("#app");
