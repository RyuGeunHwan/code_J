<template>
    <div id="app"></div>
</template>

<script>
export default {
    data(){
        return{
            todoItems:[]
        }
    },
    created(){
        if(localStorage.length>0){
            for(var i=0; i<laclStorage.length; i++){
                this.todoItems.push(lacalStorage.key(i));
            }
        }
    }
}
</script>

<style>

</style>



