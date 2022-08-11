<template>
  <div id="app">
    <div id="nav">
      <!-- 라우터를 사용해서 페이지 이동을 하려면 router-link 태그를 사용하여 to="" 속성으로 경로(index.js에서 설정한 경로)를 입력해서 페이지 이동 -->
      <!-- a태그보다 router-link태그를 선호한다. => a태그 : 리로드 O <-> router-link : 리로드 X-->
      <router-link to="/">Home!!!</router-link> 
      <router-link to="/about">About!!!</router-link>
    </div>
    <router-view/><!-- 라우터 사용 설정 -->
  </div>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}
</style>
