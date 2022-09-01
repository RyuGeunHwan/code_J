<template>
    <section>
        <ul>
            <li :key="todoItem" v-for="todoItem in todoItems">
            {{ todoItem }}
            <button @click="removeTodo">삭제</button>
            </li>
        </ul>
    </section>
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
            for(var i=0; i<localStorage.length; i++){
                this.todoItems.push(localStorage.key(i));
            }
        }
    }
}
</script>

<style>

</style>



