<template>
  <div>
    <h1>This is Home page</h1>
    <p>{{ name }}</p>
  </div>
</template>

<script>
export default{
data(){
  return{ // Object를 return
     name : 'Kossie Coder'
  }
}
}
</script>

<style scoped>
/* 현재 페이지의 h1태그만 스타일 적용 */
h1{
  color : red;
}
</style>



















