import { createRouter, createWebHistory } from "vue-router";
import MainPage from "./components/MainPage.vue";
import SignInPage from "./components/SignInPage.vue";

const routes = [
  { path: "/", component: MainPage },
  { path: "/SignIn", component: SignInPage },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
