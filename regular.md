- 匹配中文正则表达式
```
[^\u4e00-\u9fa5]
```
- 匹配双引号
```
[^"]
```
- 匹配单引号
```
[^']
```
- 匹配空白字符
```
[\s]
```
- 匹配非空白字符
```
[\S]
```
- 匹配空白字符和换行符
```
[\s\n]
```
- 匹配双引号中间是中文的字符
```
[^"]*[\u4e00-\u9fa5][^"]*
```
- 匹配电话号码
```
[0-9]{3,4}-[0-9]{7,8}
```
- 匹配邮箱
```
[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z0-9]{2,6}
```
- 匹配身份证号
```
[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)
```
- 匹配IP地址
```
((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)
```
- 匹配URL
```
[a-zA-z]+://[^\s]*
```
- 匹配HTML标签
```
<(.*)>.*</\1>|<(.*) \/>
```
- 匹配中文字符
```
[\u4e00-\u9fa5]
```
- 匹配中文字符串
```
[\u4e00-\u9fa5]+
```
- 匹配中文标点符号
```
[\u3002|\uff1f|\uff01|\uff0c|\u3001|\uff1b|\uff1a|\u201c|\u201d|\u2018|\u2019|\uff08|\uff09|\u300a|\u300b|\u3008|\u3009|\u3010|\u3011|\u300e|\u300f|\u300c|\u300d|\ufe43|\ufe44|\u3014|\u3015|\u2026|\u2014|\uff5e|\ufe4f|\uffe5]+
```
- 匹配车牌号
```
[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领A-Z]{1}[A-Z]{1}[A-Z0-9]{4}[A-Z0-9挂学警港澳]{1}
```
### 注释:
- [] 表示匹配括号中的任意字符
- [^] 表示匹配除括号中的任意字符以外的任意字符
- [a-zA-Z0-9] 表示匹配a-zA-Z0-9中的任意字符
- {n,m} 表示匹配n到m次
- {n,} 表示匹配n次以上
- {n} 表示匹配n次
- \d 表示匹配数字
- \D 表示匹配非数字
- \w 表示匹配字母数字下划线
- \W 表示匹配非字母数字下划线
- \s 表示匹配空白字符
- \S 表示匹配非空白字符
- \b 表示匹配单词边界
- \B 表示匹配非单词边界
- ^ 表示匹配字符串开头
- $ 表示匹配字符串结尾
- . 表示匹配任意字符
- \n 表示匹配换行符
- \t 表示匹配制表符
- \r 表示匹配回车符
- \f 表示匹配换页符
- \v 表示匹配垂直制表符
- \cX 表示匹配控制字符
- \xn 表示匹配十六进制n
- \un 表示匹配十六进制n
- *表示匹配前面的子表达式零次或多次
- +表示匹配前面的子表达式一次或多次
- ? 表示匹配前面的子表达式零次或一次
- {n,m} 表示匹配前面的子表达式n次到m次
- {n,} 表示匹配前面的子表达式n次以上
- {n} 表示匹配前面的子表达式n次
- | 表示匹配或
- \ 表示转义字符
 