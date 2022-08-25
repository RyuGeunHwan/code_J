# 컴포넌트 정의 방법
- <a src="https://velog.io/@jjelly/Vue.js%EC%BB%B4%ED%8F%AC%EB%84%8C%ED%8A%B8">component 참고 사이트</a><br>
- <a src="https://v3.ko.vuejs.org/guide/component-registration.html#%E1%84%8C%E1%85%B5%E1%84%8B%E1%85%A7%E1%86%A8-%E1%84%83%E1%85%B3%E1%86%BC%E1%84%85%E1%85%A9%E1%86%A8">component Reference</a><br>
```
	1. 컴포넌트의 이름은 영문 소문자만 사용
	2. 하이픈을 이용(여러 단어를 하이픈으로 연결해서 사용) == 케밥-케이스O <-> 카멜표기법X
	3. 컴포넌트를 참조만 할 경우에는 카멜표기법도 괜찮지만 DOM에 직접 사용되는 경우 케밥-케이스로 정의도니 이름만 사용가능하다.
		ex) <my-component-name></my-component-name> 이런식으로 사용
```
## 컴포넌트 전역 등록
```
+ Vue.component메서드를 전역에 등록하면 자동으로 모든 컴포넌트에서 사용할 수 있다.
	1. 사용자 정의 태그로 사용할 이름
	2. 컴포넌트의 옵션 객체(template 등)
	ex) 
	*방법1
		Vue.component('my-component',{
		 template: '<p>MyComponent</p>'
		})
		
	*방법2
		const app = Vue.createApp({})

		app.component('component-a', {
		  /* ... */
		})
		app.component('component-b', {
		  /* ... */
		})
		app.component('component-c', {
		  /* ... */
		})

		app.mount('#app')
		
	3. 등록된 컴포넌트 사용하기
	ex) 
	*방법1
		<div id="app">
		  <my-component></my-component>
		</div>
	
	*방법2
		<div id="app">
		  <component-a></component-a>
		  <component-b></component-b>
		  <component-c></component-c>
		</div>
```


## 컴포넌트 로컬 등록(지역 등록)
```
+ 컴포넌트 정의를 특정 컴포넌트의 components 옵션에 등록하면, 로컬에 등록된 해당 컴포넌트 스코프 내부에서만 해당 컴포넌트를 사용할 수 있도록 제한할 수 있다.
	1. 컴포넌트 정의하기
	ex) 
		var myComponent = {
		  template: '<p>MyComponent</p>'
		}
		
		new Vue({
		  el: '#app',
		  components: {
		  //<my-component>가 루트에서만 사용할 수 있게 됨
		  'my-component':myComponent
		  
		  
+ 지역적으로 등록된 컴포넌트는 서브 컴포넌트에서의 사용이 불가하다.
	ex) ComponentA가 ComponentB 내부에서 사용될 수 있게 하는 코드
			//ComponentA를 생성해준다.
			const ComponentA = {
			  /* ... */
			}

			const ComponentB = {
			  components: {
				'component-a': ComponentA // ComponentB안에 ComponentA를 추가해준다.
			  }
			  // ...
			}
```

## 컴포넌트 옵션
```
+ 컴포넌트에도 데이터와 메소드도 정의할 수 있다.
	ex)	  Vue.component('my-component',{
		 // 템플릿
		  template: '<p>{{ message }} </p>',
		 // 데이터는 객체를 리턴하는 함수로 지정하기
		  data:function(){
			return{
			  message:'Hello Vue.js'
			}
		  },
		  methods:{
		 // 메서드, 산출 속성, 워처의 정의 방법은
		 // 루트 생성자 객체와 같음
		  }
		})
+ data는 함수여야 한다.
	1. 컴포넌트의 옵션은 루트 생성자의 옵션과 거의 비슷하지만 데이터는 객체를 리턴하는 함수로 정의해야 한다. 
	2. 여러 개의 컴포넌트 인스턴스들이 같은 객체를 참조해서 상태를 공유되는 것을 막기 위함이다.
+ 컴포넌트 template의 루트 요소는 반드시 하나여야 한다.
	1. 템플릿의 루트 요소는 반드시 하나여야 한다(<div></div>). 여러 개의 요소가 있는 경우, 전체를 다른 어떤 요소로 감싸줘야한다.
	ex) template : '<div><span>Hello</span><span>Vue.js!</span></div>

```
## 컴포넌트끼리의 통신
```
+ 컴포넌트 인스턴스는 각각 스코프를 가지고 있다.
	* 스코프란? 영향을 미칠 수 있는 범위
	1. 스코프 내부의 데이터와 메서드는 this를 사용해서 접근할 수 있다.
		ex) this.message // 스코프 내부의 데이터
			this.update() // 스코프 내부의 메서드
```


