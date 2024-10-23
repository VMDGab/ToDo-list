<template>
  <div class="container">
    <div class="home">
      <div class="header">
        <img alt="Vue logo" src="../assets/logo.svg">
      </div>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'HomeView',
  components: {
    HelloWorld
  }
}
</script>

<style>
@import url("../global/variables.css");
.container{
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #292929;
  margin: 0;
  height: 100vh;
}
.home{
  width: 375px;
  height: 812px;
  background-color: var(--bg);
}
.header{
  display: flex;
  justify-content: flex-start;
  padding: 54px 20px 45.68px;
}
</style>
