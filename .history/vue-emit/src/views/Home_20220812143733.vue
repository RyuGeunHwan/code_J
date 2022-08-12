<!-- template태그 : HTML이 들어가는 구역  -->
<template>
  <div>
    <h1>This is Home Page</h1>
    <h2>이곳은 홈 페이지 입니다.</h2>
    <form action="">
      <InputField v-model="name"/>
        <button>Submit</button>
    </form>
    {{name}}
  </div>
</template>

<!-- script태그 : 옵션,데이터,computed,watch 등이 들어가는 구역 -->
<script>
import InputField from '@/components/InputField.vue'

export default {
  components:{
    InputField
  },
  data(){
    return{
      name : ''
    }
  },
  // methods:{
  //   updateName(name){
  //     this.name=name;
  //   }
  // }
}
</script>


<!-- style : CSS코드 -->
<!-- scoped를 넣어줘야 위에보이는 template의 html태그에 적용이 된다. scoped를 않넣으면 vue어플리케이션 전체에 적용이 된다.-->
<style scoped>
h1{
  color : red
}
</style>