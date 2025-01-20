<script setup lang="ts">
import { FormKit } from '@formkit/vue';
</script>

<template>
    <div class="container">

    <FormKit
      id="my-form"
      type="form"
      @submit.prevent=""
    >

      <FormKit
        type="text"
        label="Name"
        validation="required"
      />

      <FormKit 
        type="number"
        label="Age"
      />
      
      <FormKit 
        type="email"
        label="Email"
        validation="required"
      />

      <FormKit 
        type="password"
        label="Password"
        validation="required"
      />

    </FormKit>
    
  </div>
</template>
