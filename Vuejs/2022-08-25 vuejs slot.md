# slot개념
	- <a src="https://joshua1988.github.io/web-development/vuejs/slots/">slot 참고사이트</a><br>
	- <a src="https://www.youtube.com/watch?v=EvioDUDzKio">slot 영상</a><br>
```HTML
1. 컴포넌트의 재상용성을 높여주는 기능이다.
2. v-slot: 의 축약은 ' # '으로 대신할 수 있다.(v-bind: == : , v-on: == @)
	ex) <!-- ButtonTab.vue -->
		<template>
		  <div class="tab panel">
			<!-- 탭 헤더 -->
			<slot></slot>
			<!-- 탭 본문 -->
			<div class="content">
			  Tab Contents
			</div>
		  </div>
		</template>
<!-- 우선 탭헤더에 들어갈 구체적인 태그를 정하지 않고 <slot>태그로 빈 칸으로 남겨놓는다.
만약에 이 컴포넌트를 등록한 상위 컴포넌트에서 <slot>태그를 구현하지 않으면 빈칸으로 남게된다.	-->

		<!-- TabContainer.vue -->
		<template>
		  <button-tab>
			<!-- slot 영역 -->
			<h1>First Header</h1>
		  </button-tab>
		  <button-tab>
			<!-- slot 영역 -->
			<h1>Second Header</h1>
		  </button-tab>
		  <button-tab>
			<!-- slot 영역 -->
			<h1>Third Header</h1>
		  </button-tab>
		</template>

		<script>
		export default {
		  components: {
			ButtonTab
		  }
		}
		</script>
<!-- ButtonTab 컴포넌트를 TabContainer 컴포넌트의 하위 컴포넌트로 등록합니다. -->
		
```