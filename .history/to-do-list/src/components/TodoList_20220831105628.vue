<template>
    <section>
        <ul>
            <li :key="todoItem" v-for="(todoItem, index) in todoItems">
            {{ todoItem }}
            <button @click="removeTodo(todoItem, index)">삭제</button>
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
    },
    methods: {
        removeTodo(todoItem, index){
            console.log(todoItem);
            console.log(index)
            localStorage.removeItem(todoItem);
            console.log(todoItem, index);
             //splice()는 첫번째 인자값(index)로부터 두번째 인자값(1)만큼을 삭제한다.
            this.todoItems.splice(index,1);
        }
    }
}
</script>

<style>

</style>



