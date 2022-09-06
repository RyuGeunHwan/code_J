<template>
    <section>
        <ul>
            <li :key="todoItem" v-for="(todoItem, index) in propsdata">
            {{ todoItem }}
            <button type="button" @click="removeTodo(todoItem, index)">삭제</button>
            </li>
        </ul>
    </section>
</template>

<script>
export default {
    //props 속성 추가
    props:['propsdata'],
    methods: {
        removeTodo(todoItem, index){
            console.log('value : '+todoItem);
            console.log('index : '+index)
            localStorage.removeItem(todoItem);
             //splice()는 첫번째 인자값(index)로부터 두번째 인자값(1)만큼을 삭제한다.
            // this.todoItems.splice(index,1);
        }
    }
}
</script>

<style>

</style>



