(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-30dadaf5"],{"1da1":function(e,t,n){"use strict";n.d(t,"a",(function(){return a}));n("d3b7");function r(e,t,n,r,a,o,i){try{var c=e[o](i),u=c.value}catch(s){return void n(s)}c.done?t(u):Promise.resolve(u).then(r,a)}function a(e){return function(){var t=this,n=arguments;return new Promise((function(a,o){var i=e.apply(t,n);function c(e){r(i,a,o,c,u,"next",e)}function u(e){r(i,a,o,c,u,"throw",e)}c(void 0)}))}}},3108:function(e,t,n){"use strict";n.r(t);var r=n("7a23");function a(e,t,n,a,o,i){var c=Object(r["x"])("grid");return Object(r["p"])(),Object(r["d"])("div",null,[Object(r["g"])("section",{id:"main",class:{expand:e.expand}},[Object(r["g"])(c,{dataSource:e.dataSource,columns:e.columns,config:e.config,actions:e.actions,rows:5},null,8,["dataSource","columns","config","actions"])],2),Object(r["g"])("button",{class:"btn-table",onClick:t[1]||(t[1]=function(t){return e.goTo("TableUser",{type:"RiesgoNormativa"})})},"NIVEL DE RIESGO POR NORMATIVA")])}var o=n("5530"),i=n("1da1"),c=(n("d3b7"),n("d81d"),n("96cf"),n("9fbc")),u=n("5c40"),s=n("2fc2"),l=n("d43e"),d=n("c1df"),f=n.n(d),h=n("3e2f"),p=Object(u["l"])({components:{Grid:c["a"]},data:function(){return{columns:{},dataSource:Object(l["a"])(),config:{deleteEntity:"",entity:s["l"].USER},actions:[],page:1,entityList:[]}},mounted:function(){var e=this,t=this.$route.params.type;Object(i["a"])(regeneratorRuntime.mark((function n(){return regeneratorRuntime.wrap((function(n){while(1)switch(n.prev=n.next){case 0:n.t0=t,n.next="PlanesTratamiento"===n.t0?3:"RiesgoNormativa"===n.t0?9:"Evaluacion"===n.t0?15:21;break;case 3:return e.columns=s["g"],e.dataSource={listaRecords:h["c"],numeroPaginas:0,totalRecords:0},e.actions=[{icon:"fas fa-eye",type:s["e"].EDIT,method:e.editPlanTratamiento}],n.next=8,e.listPlanTratamiento();case 8:return n.abrupt("break",26);case 9:return e.columns=s["i"],e.dataSource={listaRecords:h["b"],numeroPaginas:0,totalRecords:0},e.actions=[{icon:"fas fa-eye",type:s["e"].EDIT,method:e.editRiesgoNormativa}],n.next=14,e.listRiesgoNormativa();case 14:return n.abrupt("break",26);case 15:return e.columns=s["f"],e.dataSource={listaRecords:h["a"],numeroPaginas:0,totalRecords:0},e.actions=[{icon:"fas fa-eye",type:s["e"].EDIT,method:e.editEvaluaciones}],n.next=20,e.listEvaluacion();case 20:return n.abrupt("break",26);case 21:return e.columns=s["g"],e.actions=[{icon:"fas fa-eye",type:s["e"].EDIT,method:e.editPlanTratamiento}],n.next=25,e.listPlanTratamiento();case 25:return n.abrupt("break",26);case 26:case"end":return n.stop()}}),n)})))()},methods:{movePage:function(e){this.page=e,console.log("move")},selectedList:function(e){this.entityList=e},editPlanTratamiento:function(){console.log("edit plan tratmiento")},deleteRiesgoNormativa:function(){console.log("deleteRiesgoNormativa")},editRiesgoNormativa:function(){console.log("editRiesgoNormativa")},deleteEvaluaciones:function(){console.log("deleteEvaluaciones")},editEvaluaciones:function(){console.log("editEvaluaciones")},listPlanTratamiento:function(){var e=this;return Object(i["a"])(regeneratorRuntime.mark((function t(){var n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(s["c"],"plantratamiento/lista?filter="),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,e.dataSource={listaRecords:[],numeroPaginas:1,totalRecords:1},t.next=7,n.json();case 7:e.dataSource.listaRecords=t.sent,e.dataSource.listaRecords=e.dataSource.listaRecords.map((function(e){return Object(o["a"])(Object(o["a"])({},e),{},{fechaInicio:e.fechaInicio?f()(e.fechaInicio).format("DD/MM/YYYY"):"",fechaFin:e.fechaFin?f()(e.fechaInicio).format("DD/MM/YYYY"):""})})),t.next=14;break;case 11:t.prev=11,t.t0=t["catch"](0),console.log(t.t0);case 14:console.log("a");case 15:case"end":return t.stop()}}),t,null,[[0,11]])})))()},listRiesgoNormativa:function(){var e=this;return Object(i["a"])(regeneratorRuntime.mark((function t(){var n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(s["c"],"plantratamiento/lista?filter="),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,e.dataSource={listaRecords:[],numeroPaginas:1,totalRecords:1},t.next=7,n.json();case 7:e.dataSource.listaRecords=t.sent,e.dataSource.listaRecords=e.dataSource.listaRecords.map((function(e){return Object(o["a"])(Object(o["a"])({},e),{},{fechaInicio:e.fechaInicio?f()(e.fechaInicio).format("DD/MM/YYYY"):"",fechaFin:e.fechaFin?f()(e.fechaInicio).format("DD/MM/YYYY"):""})})),t.next=14;break;case 11:t.prev=11,t.t0=t["catch"](0),console.log(t.t0);case 14:console.log("a");case 15:case"end":return t.stop()}}),t,null,[[0,11]])})))()},listEvaluacion:function(){var e=this;return Object(i["a"])(regeneratorRuntime.mark((function t(){var n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(s["c"],"evaluacion/lista?filter="),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,e.dataSource={listaRecords:[],numeroPaginas:1,totalRecords:1},t.next=7,n.json();case 7:e.dataSource.listaRecords=t.sent,e.dataSource.listaRecords=e.dataSource.listaRecords.map((function(e){return Object(o["a"])(Object(o["a"])({},e),{},{fechaInicio:e.fechaInicio?f()(e.fechaInicio).format("DD/MM/YYYY"):"",fechaFin:e.fechaFin?f()(e.fechaInicio).format("DD/MM/YYYY"):""})})),t.next=14;break;case 11:t.prev=11,t.t0=t["catch"](0),console.log(t.t0);case 14:case"end":return t.stop()}}),t,null,[[0,11]])})))()}}});p.render=a;t["default"]=p},"3e2f":function(e,t,n){"use strict";n.d(t,"k",(function(){return r})),n.d(t,"n",(function(){return a})),n.d(t,"h",(function(){return o})),n.d(t,"f",(function(){return i})),n.d(t,"i",(function(){return c})),n.d(t,"g",(function(){return u})),n.d(t,"e",(function(){return s})),n.d(t,"m",(function(){return l})),n.d(t,"j",(function(){return d})),n.d(t,"l",(function(){return f})),n.d(t,"o",(function(){return h})),n.d(t,"d",(function(){return p})),n.d(t,"c",(function(){return m})),n.d(t,"a",(function(){return g})),n.d(t,"b",(function(){return v}));var r=[{name:"PRODUCT A",data:[44,55,41,67,22,43]},{name:"PRODUCT B",data:[13,23,20,8,13,27]},{name:"PRODUCT C",data:[11,17,15,15,21,14]},{name:"PRODUCT D",data:[21,7,25,13,22,8]}],a=["01/01/2011 GMT","01/02/2011 GMT","01/03/2011 GMT","01/04/2011 GMT","01/05/2011 GMT","01/06/2011 GMT"],o=[44,55,13,43,22],i=["Team A","Team B","Team C","Team D","Team E"],c=[44,55,13,43,22],u=["Team A","Team B","Team C","Team D","Team E"],s=[{name:"High - 2013",data:[12,29,33,36,32,32,33]},{name:"Low - 2013",data:[28,11,14,18,17,13,13]}],l=[{data:[{x:"New Delhi",y:218},{x:"Kolkata",y:149},{x:"Mumbai",y:184},{x:"Ahmedabad",y:55},{x:"Bangaluru",y:84},{x:"Pune",y:31},{x:"Chennai",y:70},{x:"Jaipur",y:30},{x:"Surat",y:44},{x:"Hyderabad",y:68},{x:"Lucknow",y:28},{x:"Indore",y:19},{x:"Kanpur",y:29}]}],d=[62.99,37.01],f=[{name:"Marine Sprite",data:[44,55,41,37,22,43,21]},{name:"Striking Calf",data:[53,32,33,52,13,43,32]},{name:"Tank Picture",data:[12,17,11,9,15,11,20]},{name:"Bucket Slope",data:[9,7,5,8,6,9,4]},{name:"Reborn Kid",data:[25,12,19,32,25,24,10]}],h=[2008,2009,2010,2011,2012,2013,2014],p={listaRecords:[],numeroPaginas:1,totalRecords:0},m=[{codigo:"TR001",fechaInicio:"05/06/2021",fechaFin:"11/06/2021",estado:"Solucionado",evaluacion:"EV001-Departamento Bohem",responsable:"Luis Quispe"},{codigo:"TR002",fechaInicio:"01/01/2021",fechaFin:"07/01/2021",estado:"Asignado",evaluacion:"EV002-Departamento Plaza 27",responsable:"Marcelo Lopez"}],g=[{codigo:"EV001",obra:"OB001-Departamento Bohem",nivelRiesgo:"Bajo",porcentajeCumplimiento:"30%",duracion:"12"},{codigo:"EV002",obra:"OB002-Departamento Plaza 27",nivelRiesgo:"Medio",porcentajeCumplimiento:"60%",duracion:"24"}],v=[{normativa:"29783",codigoEvaluacion:"EV001",evaluacion:"Evaluacion de elementos de seguridad",nivelRiesgo:"Medio",fechaCreacion:"15/05/2021"},{normativa:"ISO 45001",codigoEvaluacion:"EV002",evaluacion:"Evaluacion de elementos peligrosos",nivelRiesgo:"Bajo",fechaCreacion:"25/05/2021"}]},"53c6":function(e,t,n){},5899:function(e,t){e.exports="\t\n\v\f\r                　\u2028\u2029\ufeff"},"58a8":function(e,t,n){var r=n("1d80"),a=n("5899"),o="["+a+"]",i=RegExp("^"+o+o+"*"),c=RegExp(o+o+"*$"),u=function(e){return function(t){var n=String(r(t));return 1&e&&(n=n.replace(i,"")),2&e&&(n=n.replace(c,"")),n}};e.exports={start:u(1),end:u(2),trim:u(3)}},"682b":function(e,t,n){"use strict";function r(e){var t=new Date(e),n=Date.now()-t.getTime(),r=new Date(n);return Math.abs(r.getUTCFullYear()-1970)}n.d(t,"a",(function(){return r}))},7156:function(e,t,n){var r=n("861d"),a=n("d2bb");e.exports=function(e,t,n){var o,i;return a&&"function"==typeof(o=t.constructor)&&o!==n&&r(i=o.prototype)&&i!==n.prototype&&a(e,i),e}},"96cf":function(e,t,n){var r=function(e){"use strict";var t,n=Object.prototype,r=n.hasOwnProperty,a="function"===typeof Symbol?Symbol:{},o=a.iterator||"@@iterator",i=a.asyncIterator||"@@asyncIterator",c=a.toStringTag||"@@toStringTag";function u(e,t,n){return Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}),e[t]}try{u({},"")}catch(P){u=function(e,t,n){return e[t]=n}}function s(e,t,n,r){var a=t&&t.prototype instanceof g?t:g,o=Object.create(a.prototype),i=new I(r||[]);return o._invoke=x(e,n,i),o}function l(e,t,n){try{return{type:"normal",arg:e.call(t,n)}}catch(P){return{type:"throw",arg:P}}}e.wrap=s;var d="suspendedStart",f="suspendedYield",h="executing",p="completed",m={};function g(){}function v(){}function y(){}var b={};u(b,o,(function(){return this}));var O=Object.getPrototypeOf,j=O&&O(O(N([])));j&&j!==n&&r.call(j,o)&&(b=j);var w=y.prototype=g.prototype=Object.create(b);function R(e){["next","throw","return"].forEach((function(t){u(e,t,(function(e){return this._invoke(t,e)}))}))}function E(e,t){function n(a,o,i,c){var u=l(e[a],e,o);if("throw"!==u.type){var s=u.arg,d=s.value;return d&&"object"===typeof d&&r.call(d,"__await")?t.resolve(d.__await).then((function(e){n("next",e,i,c)}),(function(e){n("throw",e,i,c)})):t.resolve(d).then((function(e){s.value=e,i(s)}),(function(e){return n("throw",e,i,c)}))}c(u.arg)}var a;function o(e,r){function o(){return new t((function(t,a){n(e,r,t,a)}))}return a=a?a.then(o,o):o()}this._invoke=o}function x(e,t,n){var r=d;return function(a,o){if(r===h)throw new Error("Generator is already running");if(r===p){if("throw"===a)throw o;return L()}n.method=a,n.arg=o;while(1){var i=n.delegate;if(i){var c=k(i,n);if(c){if(c===m)continue;return c}}if("next"===n.method)n.sent=n._sent=n.arg;else if("throw"===n.method){if(r===d)throw r=p,n.arg;n.dispatchException(n.arg)}else"return"===n.method&&n.abrupt("return",n.arg);r=h;var u=l(e,t,n);if("normal"===u.type){if(r=n.done?p:f,u.arg===m)continue;return{value:u.arg,done:n.done}}"throw"===u.type&&(r=p,n.method="throw",n.arg=u.arg)}}}function k(e,n){var r=e.iterator[n.method];if(r===t){if(n.delegate=null,"throw"===n.method){if(e.iterator["return"]&&(n.method="return",n.arg=t,k(e,n),"throw"===n.method))return m;n.method="throw",n.arg=new TypeError("The iterator does not provide a 'throw' method")}return m}var a=l(r,e.iterator,n.arg);if("throw"===a.type)return n.method="throw",n.arg=a.arg,n.delegate=null,m;var o=a.arg;return o?o.done?(n[e.resultName]=o.value,n.next=e.nextLoc,"return"!==n.method&&(n.method="next",n.arg=t),n.delegate=null,m):o:(n.method="throw",n.arg=new TypeError("iterator result is not an object"),n.delegate=null,m)}function S(e){var t={tryLoc:e[0]};1 in e&&(t.catchLoc=e[1]),2 in e&&(t.finallyLoc=e[2],t.afterLoc=e[3]),this.tryEntries.push(t)}function T(e){var t=e.completion||{};t.type="normal",delete t.arg,e.completion=t}function I(e){this.tryEntries=[{tryLoc:"root"}],e.forEach(S,this),this.reset(!0)}function N(e){if(e){var n=e[o];if(n)return n.call(e);if("function"===typeof e.next)return e;if(!isNaN(e.length)){var a=-1,i=function n(){while(++a<e.length)if(r.call(e,a))return n.value=e[a],n.done=!1,n;return n.value=t,n.done=!0,n};return i.next=i}}return{next:L}}function L(){return{value:t,done:!0}}return v.prototype=y,u(w,"constructor",y),u(y,"constructor",v),v.displayName=u(y,c,"GeneratorFunction"),e.isGeneratorFunction=function(e){var t="function"===typeof e&&e.constructor;return!!t&&(t===v||"GeneratorFunction"===(t.displayName||t.name))},e.mark=function(e){return Object.setPrototypeOf?Object.setPrototypeOf(e,y):(e.__proto__=y,u(e,c,"GeneratorFunction")),e.prototype=Object.create(w),e},e.awrap=function(e){return{__await:e}},R(E.prototype),u(E.prototype,i,(function(){return this})),e.AsyncIterator=E,e.async=function(t,n,r,a,o){void 0===o&&(o=Promise);var i=new E(s(t,n,r,a),o);return e.isGeneratorFunction(n)?i:i.next().then((function(e){return e.done?e.value:i.next()}))},R(w),u(w,c,"Generator"),u(w,o,(function(){return this})),u(w,"toString",(function(){return"[object Generator]"})),e.keys=function(e){var t=[];for(var n in e)t.push(n);return t.reverse(),function n(){while(t.length){var r=t.pop();if(r in e)return n.value=r,n.done=!1,n}return n.done=!0,n}},e.values=N,I.prototype={constructor:I,reset:function(e){if(this.prev=0,this.next=0,this.sent=this._sent=t,this.done=!1,this.delegate=null,this.method="next",this.arg=t,this.tryEntries.forEach(T),!e)for(var n in this)"t"===n.charAt(0)&&r.call(this,n)&&!isNaN(+n.slice(1))&&(this[n]=t)},stop:function(){this.done=!0;var e=this.tryEntries[0],t=e.completion;if("throw"===t.type)throw t.arg;return this.rval},dispatchException:function(e){if(this.done)throw e;var n=this;function a(r,a){return c.type="throw",c.arg=e,n.next=r,a&&(n.method="next",n.arg=t),!!a}for(var o=this.tryEntries.length-1;o>=0;--o){var i=this.tryEntries[o],c=i.completion;if("root"===i.tryLoc)return a("end");if(i.tryLoc<=this.prev){var u=r.call(i,"catchLoc"),s=r.call(i,"finallyLoc");if(u&&s){if(this.prev<i.catchLoc)return a(i.catchLoc,!0);if(this.prev<i.finallyLoc)return a(i.finallyLoc)}else if(u){if(this.prev<i.catchLoc)return a(i.catchLoc,!0)}else{if(!s)throw new Error("try statement without catch or finally");if(this.prev<i.finallyLoc)return a(i.finallyLoc)}}}},abrupt:function(e,t){for(var n=this.tryEntries.length-1;n>=0;--n){var a=this.tryEntries[n];if(a.tryLoc<=this.prev&&r.call(a,"finallyLoc")&&this.prev<a.finallyLoc){var o=a;break}}o&&("break"===e||"continue"===e)&&o.tryLoc<=t&&t<=o.finallyLoc&&(o=null);var i=o?o.completion:{};return i.type=e,i.arg=t,o?(this.method="next",this.next=o.finallyLoc,m):this.complete(i)},complete:function(e,t){if("throw"===e.type)throw e.arg;return"break"===e.type||"continue"===e.type?this.next=e.arg:"return"===e.type?(this.rval=this.arg=e.arg,this.method="return",this.next="end"):"normal"===e.type&&t&&(this.next=t),m},finish:function(e){for(var t=this.tryEntries.length-1;t>=0;--t){var n=this.tryEntries[t];if(n.finallyLoc===e)return this.complete(n.completion,n.afterLoc),T(n),m}},catch:function(e){for(var t=this.tryEntries.length-1;t>=0;--t){var n=this.tryEntries[t];if(n.tryLoc===e){var r=n.completion;if("throw"===r.type){var a=r.arg;T(n)}return a}}throw new Error("illegal catch attempt")},delegateYield:function(e,n,r){return this.delegate={iterator:N(e),resultName:n,nextLoc:r},"next"===this.method&&(this.arg=t),m}},e}(e.exports);try{regeneratorRuntime=r}catch(a){"object"===typeof globalThis?globalThis.regeneratorRuntime=r:Function("r","regeneratorRuntime = r")(r)}},"9fbc":function(e,t,n){"use strict";var r=n("7a23"),a=Object(r["J"])("data-v-a176ad44");Object(r["s"])("data-v-a176ad44");var o={class:"grid"},i={key:0},c={key:1},u={key:0},s=Object(r["g"])("br",null,null,-1),l={key:0},d={key:1,class:"no-data"},f={key:0},h={key:1},p={key:0};Object(r["q"])();var m=a((function(e,t,n,a,m,g){var v,y,b;return Object(r["p"])(),Object(r["d"])(r["a"],null,[Object(r["g"])("table",o,[Object(r["g"])("thead",{class:e.rowHeaderStyle?"".concat(e.rowHeaderStyle," header-grid"):"header-grid"},[Object(r["g"])("tr",null,[(null===(v=e.actions)||void 0===v?void 0:v.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(r["p"])(),Object(r["d"])("th",i,[Object(r["H"])(Object(r["g"])("input",{type:"checkbox",id:"checkbox","onUpdate:modelValue":t[1]||(t[1]=function(t){return e.massiveCheck=t})},null,512),[[r["B"],e.massiveCheck]])])):Object(r["e"])("",!0),(Object(r["p"])(!0),Object(r["d"])(r["a"],null,Object(r["v"])(e.columns,(function(e){return Object(r["p"])(),Object(r["d"])("th",{key:e.field,style:{textAlign:e.align?e.align:"left"}},Object(r["z"])(e.title),5)})),128)),(null===(y=e.actions)||void 0===y?void 0:y.length)>0?(Object(r["p"])(),Object(r["d"])("th",c,"Acciones")):Object(r["e"])("",!0)])],2),e.dataSource.listaRecords&&0===(null===(b=e.dataSource.listaRecords)||void 0===b?void 0:b.length)?(Object(r["p"])(),Object(r["d"])("div",u,[s,e.rowBodyStyle?(Object(r["p"])(),Object(r["d"])("p",d,"Sin registros")):(Object(r["p"])(),Object(r["d"])("h3",l,"No hay datos registrados"))])):Object(r["e"])("",!0),Object(r["g"])("tbody",{class:e.rowBodyStyle?e.rowBodyStyle:""},[(Object(r["p"])(!0),Object(r["d"])(r["a"],null,Object(r["v"])(e.rows,(function(n,a){var o,i;return Object(r["p"])(),Object(r["d"])("tr",{key:n},[(null===(o=e.actions)||void 0===o?void 0:o.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(r["p"])(),Object(r["d"])("td",f,[e.dataSource.listaRecords&&e.dataSource.listaRecords[a]?Object(r["H"])((Object(r["p"])(),Object(r["d"])("input",{key:0,type:"checkbox",id:e.dataSource.listaRecords[a].id,value:e.dataSource.listaRecords[a].id,"onUpdate:modelValue":t[2]||(t[2]=function(t){return e.checkedEntities=t})},null,8,["id","value"])),[[r["B"],e.checkedEntities]]):Object(r["e"])("",!0)])):Object(r["e"])("",!0),(Object(r["p"])(!0),Object(r["d"])(r["a"],null,Object(r["v"])(e.columns,(function(t){return Object(r["p"])(),Object(r["d"])("td",{key:t.field},[Object(r["g"])("p",{style:{textAlign:t.align?t.align:"left"}},Object(r["z"])(e.getValue(t.field,e.dataSource.listaRecords,n-1)),5)])})),128)),(null===(i=e.actions)||void 0===i?void 0:i.length)>0?(Object(r["p"])(),Object(r["d"])("td",h,[(Object(r["p"])(!0),Object(r["d"])(r["a"],null,Object(r["v"])(e.actions,(function(t){return Object(r["p"])(),Object(r["d"])("span",{key:t.type},[e.dataSource.listaRecords[a]?(Object(r["p"])(),Object(r["d"])("i",{key:0,class:t.icon,style:{"margin-left":"18px"},onClick:function(n){return t.method(e.dataSource.listaRecords[a].id,e.dataSource.listaRecords[a].entity)}},null,10,["onClick"])):Object(r["e"])("",!0)])})),128))])):Object(r["e"])("",!0)])})),128))],2)]),e.dataSource.numeroPaginas>1?(Object(r["p"])(),Object(r["d"])("div",p,[(Object(r["p"])(!0),Object(r["d"])(r["a"],null,Object(r["v"])(e.dataSource.numeroPaginas,(function(t){return Object(r["p"])(),Object(r["d"])("div",{key:t,class:"pageButton",onClick:function(n){return e.goPage(t)}},Object(r["z"])(t),9,["onClick"])})),128))])):Object(r["e"])("",!0)],64)})),g=(n("a9e3"),n("d81d"),n("682b")),v=n("5c40");function y(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}var b=function e(t,n,r){y(this,e),this.listaRecords=t,this.numeroPaginas=n,this.totalRecords=r},O=Object(v["l"])({props:{columns:{type:Array,required:!0},dataSource:{type:b,required:!0},config:{type:null,required:!1},actions:{type:null,required:!1,default:[]},method:{type:Function,required:!1},rows:{type:Number,required:!1,default:5},pages:{type:Number,required:!0},rowHeaderStyle:{type:String,required:!1},rowBodyStyle:{type:String,required:!1}},emits:["selectedList","movePage"],data:function(){return{massiveCheck:!1,checkedEntities:[]}},watch:{massiveCheck:function(){this.massiveCheck?this.checkedEntities=this.dataSource.listaRecords.map((function(e){return e.id})):this.checkedEntities=[]},checkedEntities:function(){this.$emit("selectedList",this.checkedEntities)}},methods:{goPage:function(e){this.$emit("movePage",e)},getValue:function(e,t,n){if(t)return t[n]?"fechaNacimiento"===e?Object(g["a"])(t[n][e]):t[n][e]:""}}});n("ecd5");O.render=m,O.__scopeId="data-v-a176ad44";t["a"]=O},a9e3:function(e,t,n){"use strict";var r=n("83ab"),a=n("da84"),o=n("94ca"),i=n("6eeb"),c=n("5135"),u=n("c6b6"),s=n("7156"),l=n("c04e"),d=n("d039"),f=n("7c73"),h=n("241c").f,p=n("06cf").f,m=n("9bf2").f,g=n("58a8").trim,v="Number",y=a[v],b=y.prototype,O=u(f(b))==v,j=function(e){var t,n,r,a,o,i,c,u,s=l(e,!1);if("string"==typeof s&&s.length>2)if(s=g(s),t=s.charCodeAt(0),43===t||45===t){if(n=s.charCodeAt(2),88===n||120===n)return NaN}else if(48===t){switch(s.charCodeAt(1)){case 66:case 98:r=2,a=49;break;case 79:case 111:r=8,a=55;break;default:return+s}for(o=s.slice(2),i=o.length,c=0;c<i;c++)if(u=o.charCodeAt(c),u<48||u>a)return NaN;return parseInt(o,r)}return+s};if(o(v,!y(" 0o1")||!y("0b1")||y("+0x1"))){for(var w,R=function(e){var t=arguments.length<1?0:e,n=this;return n instanceof R&&(O?d((function(){b.valueOf.call(n)})):u(n)!=v)?s(new y(j(t)),n,R):j(t)},E=r?h(y):"MAX_VALUE,MIN_VALUE,NaN,NEGATIVE_INFINITY,POSITIVE_INFINITY,EPSILON,isFinite,isInteger,isNaN,isSafeInteger,MAX_SAFE_INTEGER,MIN_SAFE_INTEGER,parseFloat,parseInt,isInteger,fromString,range".split(","),x=0;E.length>x;x++)c(y,w=E[x])&&!c(R,w)&&m(R,w,p(y,w));R.prototype=b,b.constructor=R,i(a,v,R)}},d81d:function(e,t,n){"use strict";var r=n("23e7"),a=n("b727").map,o=n("1dde"),i=o("map");r({target:"Array",proto:!0,forced:!i},{map:function(e){return a(this,e,arguments.length>1?arguments[1]:void 0)}})},ecd5:function(e,t,n){"use strict";n("53c6")}}]);
//# sourceMappingURL=chunk-30dadaf5.c87ec906.js.map