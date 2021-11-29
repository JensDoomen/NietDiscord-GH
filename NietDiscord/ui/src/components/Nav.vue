<template>
  <nav class="navbar navbar-expand-md navbar-dark bg-dark mb-4">
    <div class="container-fluid">
      <router-link to="/" class="navbar-brand">Home</router-link>
      <div>
        <ul class="navbar-nav me-auto mb-2 mb-md-0" v-if="!authorized">
          <li class="nav-item">
            <router-link to="/Inlog" class="nav-link active">Login</router-link>
          </li>
          <li class="nav-item">
            <router-link to="/register" class="nav-link active">Register</router-link>
          </li>
        </ul>
        <ul class="navbar-nav me-auto mb-2 mb-md-0" v-if="authorized">
          <li class="nav-item">
            <router-link to="/login" @click="clearToken" class="nav-link active">Clear Token</router-link>
          </li>
        </ul>
      </div>
    </div>
  </nav>
</template>

<script>
export default {
  name: "Nav",
  props: {
    authorized: Boolean
  },
  methods:{
    clearToken(){
      this.$emit('clearToken');
    }
  }
}
</script>
