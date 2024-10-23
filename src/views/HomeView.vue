<template>
  <div class="container">
    <div class="home">
      <div class="header">
        <img alt="Vue logo" src="../assets/logo.svg">
      </div>
      <Status/>
      <Card title="Appoitment with the Design Team" date="25 nov. 14:00" :belated="false"/>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src
import Status from '@/components/statusTask.vue'
import Card from '@/components/taskCard.vue'

export default {
  name: 'HomeView',
  components: {
    Status,
    Card
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
  padding: 0 20px;
  width: 375px;
  height: 812px;
  background-color: var(--bg);
}
.header{
  padding: 54px 0 45.68px;
  display: flex;
  justify-content: flex-start;
}
</style>
