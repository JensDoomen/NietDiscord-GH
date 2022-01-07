<template>
  <form @submit.prevent="submitLogin">
    <h1 class="h3 mb-3 fw-normal">Please Login</h1>
    <input v-model="email" type="email" class="form-control" placeholder="Email" required>
    <input v-model="password" type="password" class="form-control" placeholder="Password" required>
    <button class="w-100 btn btn-lg btn-primary" type="submit">Submit</button>
  </form>
</template>

<script>

import axios from "axios";
export default {
  name: "Login",
  data(){
    return{
      email: "",
      password: ""
    }
    
  },
   methods:{
    submitLogin(){
      axios({
        method: 'post',
        url: 'https://localhost:44347/Authentication/login',
        data:{
          email: this.email,
          password: this.password
        }
      })
      .then((response) => {
        console.log(response.data)
        this.$emit('setToken', response.data)
      })
      // const headers = {
      //   'Content-Type': 'application/json',
      //   'Authorization': localStorage.getItem("token")
      // }
      //  axios.post('https://localhost:44347/Authentication/login',{
      //   "email": this.email,
      //   "password": this.password
      // },{headers: headers})
      //     .then((response) => {
      //       this.$emit('setToken', response.data)
      //       this.$router.push("/autherized")
      //     })
    }
  }

}
</script>


<style scoped>

</style>