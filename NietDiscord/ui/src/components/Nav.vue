<template>

  <nav class="navbar navbar-expand-md navbar-dark bg-dark mb-4">
    <div class="container-fluid">
      <router-link to="/" class="navbar-brand">Home</router-link>
      <div>
        <ul class="navbar-nav me-auto mb-2 mb-md-0" >

          <li class="nav-item">
            <router-link to="/Inlog" class="nav-link active">Login</router-link>
          </li>
          <li class = "nav-item">
          <Nav2
                      :logedIn="logedIn"
                      :email="email"
                      />
          </li>
          <li class="nav-item">
            <router-link to="/register" class="nav-link active">Register</router-link>
          </li>
          <li class="nav-item">
            <router-link to="/settings" class="nav-link active">Account</router-link>
          </li>
          <li class="nav-item">
            <router-link to="/inlog" @click="clearToken" class="nav-link active">Uitloggen</router-link>
          </li>
        </ul>
        <ul class="navbar-nav me-auto mb-2 mb-md-0" v-if="authorized">
          
        </ul> 
      </div>
    </div>
  </nav>
  <!-- <router-view  v-on:login="login"
  :logedIn="logedIn"
  /> -->
</template>

<script>
import Nav2 from '@/components/Nav2.vue' 
export default {
  template: <Nav/>,
  name: "Nav",
  props: {
    authorized: Boolean

  },
  components: {Nav2},
  data(){
    return{
      logedIn: false,
      email: '',
    }
  },
  methods:{
    clearToken(){
      localStorage.clear();
      this.$emit('clearToken');
    },
    login(data){
      localStorage.setItem('token',data);
      this.logedIn = true;
      this.email = data.email;
      this.$router.push("/autherized");
    },
  }
}
</script>
