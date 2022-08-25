
```html
<template>
  <div class="about">
    <h1>{{fullName}}</h1>
    <button @click="changeName">Click</button>
  </div>
</template>

<script>
export default {
  name : 'App',
  data(){
    return{ 
      firstName : 'Ryu',
      lastName : 'geunhwan',
    };
  },
  methods : {
    changeName(){
      this.fullName = "nin ano";
    }
  },
  computed:{
    fullName: {
        get:function(){
          console.log('3번');
          return this.firstName+''+this.lastName;
        },
        set: function(newValue){ // methods에서 full name을 "nin ano"로 줬기 때문에 set의 파라미터(newValue)에는 "nin ano"가 들어온다.
          alert('Setting new name: ' + newValue);
          var name = newValue.split(' '); //eslint-disable-line no-unused-vars
          this.firstName = name[0];
          this.lastName = name[1];
        }
      }
    }
  }
</script>
```
```
# computed의 개념 : 
  + computed속성에 접근할 경우 ()를 제외한 key값으로만 접근한다. 
     computed 프로퍼티는, Vue 인스턴스 Function 내에서 this 키워드와 연결된다.
       computed 프로퍼티는 기본적으로 getter 만 가지고 있지만, 필요하다면 setter 를 지정하는 것도 가능

# computed get : 
  + 값을 확인,가져올 때 사용
      return값이 항상 존재한다.

# computed set : 
  + 값을 설정, 변경할 때 사용
      set methods 을 설정하면, newValue 매개변수를 받습니다. 
        해당 매개변수는 computed 프로퍼티에 특정 값을 등록하고자 할 때 입력할 새로운 값을 포함하고 있습니다. 
          그래서 set methods 안에서는, data 프로퍼티를 간단하게 업데이트 할 수 있습니다.
```