- <a src="https://element.eleme.io/#/en-US/component/layout">elementUI 공식홈페이지 </a><br>
# Basic layout
## 기본적으로 layout은 한줄의 간격을 24로 나눈다.
```html
<el-row>
  <el-col :span="24"><div class="grid-content bg-purple-dark"></div></el-col>
</el-row>

# span 태그의 사이즈를 24의 약수는 설정 가능하다.(1,2,3,4,6,8,12,24)

```
# Column offset
```html
<el-row :gutter="20">
  <el-col :span="6"><div class="grid-content bg-purple"></div></el-col>
  <el-col :span="6" :offset="6"><div class="grid-content bg-purple"></div></el-col>
</el-row>

# offset 설정한 크키만큼 한줄을 기준으로 뛰어놓는다 or 뒤로 미룬다.
```
# Responsive Layout
```html
<el-row :gutter="10">
  <el-col :xs="8" :sm="6" :md="4" :lg="3" :xl="1"><div class="grid-content bg-purple"></div></el-col>
</el-row>

# 웹페이지가 xs,sm,md,lg,xl사이즈가 될때 레이아웃의 크기를 설정
풀이 : 웹페이지의 사이즈가 xs일때 레이아웃 크기는 24중에 8, sm일때는 24중에 6, md일때는 24중에 4.....로 나타내라는 뜻
```
