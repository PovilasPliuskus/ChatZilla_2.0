<script setup lang="ts">
import { FormKit } from "@formkit/vue";
import "../styles/formKitStyle.css";
</script>

<template>
  <div id="main-page-heading">ChatZilla</div>
  <div class="container">
    <div class="signup-form">
      <FormKit id="signup-form" type="form" @submit.prevent="" :actions="false">
        <FormKit type="email" label="Email" validation="required|email" />
        <FormKit type="password" label="Password" validation="required" />
        <button type="submit" class="formkit-button">Sign In</button>
      </FormKit>
      <router-link to="/SignIn" class="link-button">
        Not a dino-mite member?<br />Click here to create an account!
      </router-link>
    </div>
    <img
      src="../assets/img/ChatZilla-main-image.jpg"
      alt="ChatZilla main dinosaur image"
      class="header-image"
    />
  </div>
</template>
