<template>
  <div class="about">
    <h1>{{fullName}}</h1>
    <button @click="changeName">Click</button>
  </div>
</template>

<script>
export default {
  name : 'App',
  data(){
    return{ 
      firstName : 'Ryu',
      lastName : 'geunhwan',
    };
  },
  methods : {
    changeName(){
      this.fullName = "nin ano";
    }
  },
  computed:{
    fullName: {
        get:function(){
          console.log('3번');
          return this.firstName+''+this.lastName;
        },
        set: function(newValue){ // methods에서 full name을 "nin ano"로 줬기 때문에 set의 파라미터(newValue)에는 "nin ano"가 들어온다.
          alert('Setting new name: ' + newValue);
          var name = newValue.split(' '); //eslint-disable-line no-unused-vars
          this.firstName = name[0];
          this.lastName = name[1];
        }
      }
    }
  }
</script>