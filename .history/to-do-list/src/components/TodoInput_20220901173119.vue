<template>
    <div>
        <input type="text" v-model="newTodoItem">
        <button @click="addTodo()">추가</button>
    </div>
</template>

<script>
export default {
    data(){
        return {
            newTodoItem: ''
        }
    },
    methods: {
        addTodo(){
            //inputbox 빈값인지 체크, 빈값이 아니면 로직 수행
            if(this.newTodoItem !== ''){
                //inputbox에 입력된 텍스트의 앞, 뒤 공백문자열 제거
                var value = this.newTodoItem && this.newTodoItem.trim();
                //App컴포넌트로 이벤트 전달
                this.$emit('addTodo', value);
                //inputbox 초기화
                this.clearInputbox();
            }
        },
        clearInputbox(){
            this.newTodoItem = '';
        }
    }
}
</script>

<style>

</style>



