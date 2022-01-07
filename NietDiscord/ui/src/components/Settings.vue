<template>
<div class="container">
<div class="row gutters">
	<div class="col-xl-3 col-lg-3 col-md-12 col-sm-12 col-12">
		<div class="card h-100">
			<div class="card-body">
				<div class="account-settings">
					<div class="user-profile">
						<h5 class="user-name">{{name}}</h5>
						<h6 class="user-email">{{email}}</h6>
					</div>
					<div class="about">

						
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class="col-xl-9 col-lg-9 col-md-12 col-sm-12 col-12">
		<div class="card h-100">
			<div class="card-body">
				<div class="row gutters">
					<div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
						<h6 class="mb-3 text-primary">Personal Details</h6>
					</div>
					<div class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
						<div class="form-group">
							<label for="fullName"> {{this.name}} </label>
							<input type="text" class="form-control" id="fullName" placeholder="Enter username" v-model="newname">
						</div>
					</div>
					<div class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
						<div class="form-group">
							<label for="eMail"> {{this.email}} </label>
							<input type="email" class="form-control" id="eMail" placeholder="Enter email" v-model="newemail">
						</div>
					</div>
					<div class="col-xl-6 col-lg-6 col-md-6 col-sm-6 col-12">
						<div class="form-group">
							<label for="Password"> Confirm password </label>
							<input type="password" class="form-control" id="password" placeholder="Enter password" v-model="confirmpassword">
						</div>
					</div>
					
				
				</div>
				<div class="row gutters">
					<div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
						<div class="text-right">
							<button type="button" id="submit" name="submit" class="btn btn-secondary">Cancel</button>
							<button type="button" id="submit" name="submit" class="btn btn-primary" v-on:click="changeaccount">Update</button>
						
						</div>
							<button type="button" class="btn btn-danger" v-on:click="deleteaccount">Delete account</button>
							
					</div>
				</div>
			</div>
			
		</div>
	</div>
</div>
</div>
</template>

<script>
import axios from 'axios'
export default{

data(){
    return{
        users: [],
		name: "",
        email: "",
        password: "",
		items: []

    }
},
methods:{
read() {
	console.log("read")
    axios.get('https://localhost:44347/Authentication/getUser',{ 
	headers: {
          Authorization: 'Bearer ' + localStorage.getItem('token')} //the token is a variable which holds the token
        }).then((response) => {
          this.name = response.data.name
          this.email = response.data.email
		  console.log(response)
		


      });
        
		
        

},
changeaccount(){
	const data = {
            newname: this.name,
            newemail: this.email,
            confirmpassword: this.password,
			userId: this.userId 
          }
	 axios.put('https://localhost:44347/Authentication/changeaccount', data, {
		headers: {
          Authorization: 'Bearer ' + localStorage.getItem('token')}
	
	})
	.then(() => { 
	this.showMessage = true
	})
	


},
// const data = {
//             oldPW: this.oldPW,
//             newPW: this.newPW,
//             confirmPW: this.confirmPW
//           }
//           //voer AXIOS PUT uit
//           await axios.put('https://localhost:44319/Account/changePassword', data, {
//             headers: {
//               Authorization: Bearer ${localStorage.getItem('token')}
//             }
//           })
//           .then(() => {
//             this.showMessage = true
//           })
  

deleteaccount(){
// axios.delete('https://localhost:44347/Authentication/delete',{
// 	headers: {
//           Authorization: 'Bearer ' + localStorage.getItem('token')}
// },
// data: {this.email}
		  

// })


},
	mounted: function(){

		this.read();
      }
}
}


</script>
