<template>
    <h1 v-bind:class="{active : isActive}" @click="activate">
        Hello Vue.js!(isActive = {{ isActive }})
    </h1>

    <!-- <h1 :class="{active : isActive}" @click="activate">
        Hello Vue.js!(isActive = {{ isActive }})
    </h1> -->
</template>

<script>
    export default {
        name: 'App',
        data(){
            return{
                isActive: false,
            };
        },
        methods: {
            activate(){
                this.isActive = true;
            }
        }
    };
</script>

<style scoped>
    h1{
        color : blue;
    }
    .active{
        color: red;
        font-weight: bold;
    }
</style>



