(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-1d377684"],{1568:function(e,t,n){"use strict";n.r(t);var a=n("7a23"),r=Object(a["J"])("data-v-12cb499d"),o=r((function(e,t,n,r,o,c){var i=Object(a["x"])("confirmation-modal"),s=Object(a["x"])("modal"),l=Object(a["x"])("grid");return Object(a["p"])(),Object(a["d"])(a["a"],null,[Object(a["g"])(i,{error:null,show:e.showModalConfirmation,title:e.modalTitle,massiveDelete:e.massiveDelete,onConfirm:e.confirmDelete,onConfirmMassive:e.confirmMassiveDelete,onCancel:e.closeModal},null,8,["show","title","massiveDelete","onConfirm","onConfirmMassive","onCancel"]),Object(a["g"])(s,{show:!!e.message,title:e.message,onClose:e.handleError,error:e.error,loading:e.loading},null,8,["show","title","onClose","error","loading"]),Object(a["g"])("section",{id:"main",class:{expand:e.expand}},[Object(a["g"])("div",null,[Object(a["g"])("h2",null,"ADMINISTRACIÓN DE "+Object(a["z"])(e.calculateUser()),1),Object(a["g"])("button",{class:"action-button massive",onClick:t[1]||(t[1]=function(t){return e.deleteMassive()})}," Eliminación masiva "),Object(a["g"])("button",{class:"action-button",onClick:t[2]||(t[2]=function(t){return e.register()})},"Registrar")]),Object(a["g"])(l,{dataSource:e.dataSource,columns:e.columns,config:e.config,actions:e.actions,rows:5,onMovePage:e.movePage,onSelectedList:e.selectedList},null,8,["dataSource","columns","config","actions","onMovePage","onSelectedList"])],2)],64)})),c=n("1da1"),i=(n("96cf"),n("d3b7"),n("99af"),n("3ca3"),n("ddb0"),n("d81d"),n("9fbc")),s=n("b7ff"),l=n("705f"),u=n("2fc2"),d=n("5c40"),f=n("d43e"),b=Object(d["l"])({components:{Grid:i["a"],ConfirmationModal:s["a"],Modal:l["a"]},data:function(){return{profileUrl:"",userRol:"",userInfoJson:null,dataSource:Object(f["a"])(),columns:u["j"],config:{deleteEntity:"",entity:u["l"].USER},actions:[{icon:"fas fa-trash-alt",type:u["e"].DELETE,method:this.delete},{icon:"fas fa-eye",type:u["e"].EDIT,method:this.edit}],modalTitle:"",showModalConfirmation:!1,id:"",entity:"",message:null,loading:!1,error:!1,entityList:[],massiveDelete:!1,expand:!1,page:1,quantity:5}},methods:{movePage:function(e){this.page=e,this.listUsersByRol()},expandMain:function(e){this.expand=!e},selectedList:function(e){this.entityList=e},handleError:function(){this.message=null},closeModal:function(){this.showModalConfirmation=!1},calculateUser:function(){switch(console.log(this.$route),this.$route.path){case"/dashboard/alta-gerencia":this.userRol="ALTA GERENCIA",this.profileUrl="/dashboard/profile/alta-gerencia/";break;case"/dashboard/analistas":this.userRol="ANALISTAS",this.profileUrl="/dashboard/profile/analista/";break}return this.userRol},listUsersByRol:function(){var e=this;return Object(c["a"])(regeneratorRuntime.mark((function t(){var n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(u["c"],"usuario/listar/").concat(e.userRol,"?page=").concat(e.page,"&quantity=").concat(e.quantity),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,t.next=6,n.json();case 6:e.dataSource=t.sent,console.log("this.dataSource"),console.log(e.dataSource),t.next=14;break;case 11:t.prev=11,t.t0=t["catch"](0),console.log(t.t0);case 14:case"end":return t.stop()}}),t,null,[[0,11]])})))()},deleteMassive:function(){this.entityList.length>0?(this.massiveDelete=!0,this.showModalConfirmation=!0,this.modalTitle="Está seguro que desea eliminar los usuarios seleccionados ?"):(this.message="Debe seleccionar al menos un usuario",this.error=!0),this.page=1},register:function(){this.$router.push(this.profileUrl)},edit:function(e,t){t===u["l"].USER&&this.$router.push(this.profileUrl+e)},delete:function(e,t){this.id=e,this.entity=t,this.modalTitle="Está seguro que desea eliminar "+t+"?",this.showModalConfirmation=!0,this.page=1},confirmMassiveDelete:function(){var e=this;return Object(c["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return console.log(e.entityList),t.next=3,Promise.all(e.entityList.map(function(){var e=Object(c["a"])(regeneratorRuntime.mark((function e(t){return regeneratorRuntime.wrap((function(e){while(1)switch(e.prev=e.next){case 0:return e.prev=0,e.next=3,fetch("".concat(u["c"],"usuario/").concat(t),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:e.sent,e.next=9;break;case 6:e.prev=6,e.t0=e["catch"](0),console.log(e.t0);case 9:case"end":return e.stop()}}),e,null,[[0,6]])})));return function(t){return e.apply(this,arguments)}}()));case 3:e.massiveDelete=!1,e.showModalConfirmation=!1,e.modalTitle="",e.message="Los usuarios  fueron eliminados",setTimeout(Object(c["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.listUsersByRol();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3);case 8:case"end":return t.stop()}}),t)})))()},confirmDelete:function(){var e=this;return Object(c["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return e.closeModal(),t.prev=1,t.next=4,fetch("".concat(u["c"]).concat(e.entity,"/").concat(e.id),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 4:t.sent,e.message="El ".concat(e.entity," fue eliminado"),e.id="",e.entity="",setTimeout(Object(c["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.listUsersByRol();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3),t.next=14;break;case 11:t.prev=11,t.t0=t["catch"](1),console.log(t.t0);case 14:case"end":return t.stop()}}),t,null,[[1,11]])})))()}},mounted:function(){var e=this;Object(c["a"])(regeneratorRuntime.mark((function t(){var n,a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(u["c"],"usuario"),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,t.next=6,n.json();case 6:a=t.sent,e.userInfoJson=a,t.next=13;break;case 10:t.prev=10,t.t0=t["catch"](0),console.log(t.t0);case 13:return t.next=15,e.listUsersByRol();case 15:case"end":return t.stop()}}),t,null,[[0,10]])})))()}});n("afb7");b.render=o,b.__scopeId="data-v-12cb499d";t["default"]=b},"53c6":function(e,t,n){},5899:function(e,t){e.exports="\t\n\v\f\r                　\u2028\u2029\ufeff"},"58a8":function(e,t,n){var a=n("1d80"),r=n("5899"),o="["+r+"]",c=RegExp("^"+o+o+"*"),i=RegExp(o+o+"*$"),s=function(e){return function(t){var n=String(a(t));return 1&e&&(n=n.replace(c,"")),2&e&&(n=n.replace(i,"")),n}};e.exports={start:s(1),end:s(2),trim:s(3)}},"5ef3":function(e,t,n){},"682b":function(e,t,n){"use strict";function a(e){var t=new Date(e),n=Date.now()-t.getTime(),a=new Date(n);return Math.abs(a.getUTCFullYear()-1970)}n.d(t,"a",(function(){return a}))},7156:function(e,t,n){var a=n("861d"),r=n("d2bb");e.exports=function(e,t,n){var o,c;return r&&"function"==typeof(o=t.constructor)&&o!==n&&a(c=o.prototype)&&c!==n.prototype&&r(e,c),e}},"9fbc":function(e,t,n){"use strict";var a=n("7a23"),r=Object(a["J"])("data-v-a176ad44");Object(a["s"])("data-v-a176ad44");var o={class:"grid"},c={key:0},i={key:1},s={key:0},l=Object(a["g"])("br",null,null,-1),u={key:0},d={key:1,class:"no-data"},f={key:0},b={key:1},h={key:0};Object(a["q"])();var p=r((function(e,t,n,r,p,g){var m,j,O;return Object(a["p"])(),Object(a["d"])(a["a"],null,[Object(a["g"])("table",o,[Object(a["g"])("thead",{class:e.rowHeaderStyle?"".concat(e.rowHeaderStyle," header-grid"):"header-grid"},[Object(a["g"])("tr",null,[(null===(m=e.actions)||void 0===m?void 0:m.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(a["p"])(),Object(a["d"])("th",c,[Object(a["H"])(Object(a["g"])("input",{type:"checkbox",id:"checkbox","onUpdate:modelValue":t[1]||(t[1]=function(t){return e.massiveCheck=t})},null,512),[[a["B"],e.massiveCheck]])])):Object(a["e"])("",!0),(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.columns,(function(e){return Object(a["p"])(),Object(a["d"])("th",{key:e.field,style:{textAlign:e.align?e.align:"left"}},Object(a["z"])(e.title),5)})),128)),(null===(j=e.actions)||void 0===j?void 0:j.length)>0?(Object(a["p"])(),Object(a["d"])("th",i,"Acciones")):Object(a["e"])("",!0)])],2),e.dataSource.listaRecords&&0===(null===(O=e.dataSource.listaRecords)||void 0===O?void 0:O.length)?(Object(a["p"])(),Object(a["d"])("div",s,[l,e.rowBodyStyle?(Object(a["p"])(),Object(a["d"])("p",d,"Sin registros")):(Object(a["p"])(),Object(a["d"])("h3",u,"No hay datos registrados"))])):Object(a["e"])("",!0),Object(a["g"])("tbody",{class:e.rowBodyStyle?e.rowBodyStyle:""},[(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.rows,(function(n,r){var o,c;return Object(a["p"])(),Object(a["d"])("tr",{key:n},[(null===(o=e.actions)||void 0===o?void 0:o.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(a["p"])(),Object(a["d"])("td",f,[e.dataSource.listaRecords&&e.dataSource.listaRecords[r]?Object(a["H"])((Object(a["p"])(),Object(a["d"])("input",{key:0,type:"checkbox",id:e.dataSource.listaRecords[r].id,value:e.dataSource.listaRecords[r].id,"onUpdate:modelValue":t[2]||(t[2]=function(t){return e.checkedEntities=t})},null,8,["id","value"])),[[a["B"],e.checkedEntities]]):Object(a["e"])("",!0)])):Object(a["e"])("",!0),(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.columns,(function(t){return Object(a["p"])(),Object(a["d"])("td",{key:t.field},[Object(a["g"])("p",{style:{textAlign:t.align?t.align:"left"}},Object(a["z"])(e.getValue(t.field,e.dataSource.listaRecords,n-1)),5)])})),128)),(null===(c=e.actions)||void 0===c?void 0:c.length)>0?(Object(a["p"])(),Object(a["d"])("td",b,[(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.actions,(function(t){return Object(a["p"])(),Object(a["d"])("span",{key:t.type},[e.dataSource.listaRecords[r]?(Object(a["p"])(),Object(a["d"])("i",{key:0,class:t.icon,style:{"margin-left":"18px"},onClick:function(n){return t.method(e.dataSource.listaRecords[r].id,e.dataSource.listaRecords[r].entity)}},null,10,["onClick"])):Object(a["e"])("",!0)])})),128))])):Object(a["e"])("",!0)])})),128))],2)]),e.dataSource.numeroPaginas>1?(Object(a["p"])(),Object(a["d"])("div",h,[(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.dataSource.numeroPaginas,(function(t){return Object(a["p"])(),Object(a["d"])("div",{key:t,class:"pageButton",onClick:function(n){return e.goPage(t)}},Object(a["z"])(t),9,["onClick"])})),128))])):Object(a["e"])("",!0)],64)})),g=(n("a9e3"),n("d81d"),n("682b")),m=n("5c40");function j(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}var O=function e(t,n,a){j(this,e),this.listaRecords=t,this.numeroPaginas=n,this.totalRecords=a},v=Object(m["l"])({props:{columns:{type:Array,required:!0},dataSource:{type:O,required:!0},config:{type:null,required:!1},actions:{type:null,required:!1,default:[]},method:{type:Function,required:!1},rows:{type:Number,required:!1,default:5},pages:{type:Number,required:!0},rowHeaderStyle:{type:String,required:!1},rowBodyStyle:{type:String,required:!1}},emits:["selectedList","movePage"],data:function(){return{massiveCheck:!1,checkedEntities:[]}},watch:{massiveCheck:function(){this.massiveCheck?this.checkedEntities=this.dataSource.listaRecords.map((function(e){return e.id})):this.checkedEntities=[]},checkedEntities:function(){this.$emit("selectedList",this.checkedEntities)}},methods:{goPage:function(e){this.$emit("movePage",e)},getValue:function(e,t,n){if(t)return t[n]?"fechaNacimiento"===e?Object(g["a"])(t[n][e]):t[n][e]:""}}});n("ecd5");v.render=p,v.__scopeId="data-v-a176ad44";t["a"]=v},a9e3:function(e,t,n){"use strict";var a=n("83ab"),r=n("da84"),o=n("94ca"),c=n("6eeb"),i=n("5135"),s=n("c6b6"),l=n("7156"),u=n("c04e"),d=n("d039"),f=n("7c73"),b=n("241c").f,h=n("06cf").f,p=n("9bf2").f,g=n("58a8").trim,m="Number",j=r[m],O=j.prototype,v=s(f(O))==m,y=function(e){var t,n,a,r,o,c,i,s,l=u(e,!1);if("string"==typeof l&&l.length>2)if(l=g(l),t=l.charCodeAt(0),43===t||45===t){if(n=l.charCodeAt(2),88===n||120===n)return NaN}else if(48===t){switch(l.charCodeAt(1)){case 66:case 98:a=2,r=49;break;case 79:case 111:a=8,r=55;break;default:return+l}for(o=l.slice(2),c=o.length,i=0;i<c;i++)if(s=o.charCodeAt(i),s<48||s>r)return NaN;return parseInt(o,a)}return+l};if(o(m,!j(" 0o1")||!j("0b1")||j("+0x1"))){for(var w,k=function(e){var t=arguments.length<1?0:e,n=this;return n instanceof k&&(v?d((function(){O.valueOf.call(n)})):s(n)!=m)?l(new j(y(t)),n,k):y(t)},S=a?b(j):"MAX_VALUE,MIN_VALUE,NaN,NEGATIVE_INFINITY,POSITIVE_INFINITY,EPSILON,isFinite,isInteger,isNaN,isSafeInteger,MAX_SAFE_INTEGER,MIN_SAFE_INTEGER,parseFloat,parseInt,isInteger,fromString,range".split(","),R=0;S.length>R;R++)i(j,w=S[R])&&!i(k,w)&&p(k,w,h(j,w));k.prototype=O,O.constructor=k,c(r,m,k)}},aa14:function(e,t,n){"use strict";n("5ef3")},afb7:function(e,t,n){"use strict";n("b887")},b7ff:function(e,t,n){"use strict";var a=n("7a23"),r=Object(a["J"])("data-v-ea440b04");Object(a["s"])("data-v-ea440b04");var o={key:0,class:"modal"},c=Object(a["g"])("i",{class:"far fa-times-circle fa-2x"},null,-1),i={class:"flex-button"};Object(a["q"])();var s=r((function(e,t,n,r,s,l){var u=Object(a["x"])("backdrop");return Object(a["p"])(),Object(a["d"])(a["a"],null,[Object(a["g"])(u,{show:e.show,onClose:e.tryClose,closable:!1},null,8,["show","onClose"]),e.show?(Object(a["p"])(),Object(a["d"])("div",o,[c,Object(a["g"])("p",null,Object(a["z"])(e.title),1),Object(a["g"])("div",i,[Object(a["g"])("button",{onClick:t[1]||(t[1]=function(t){return e.confirm()}),class:"action-button"},"Aceptar"),Object(a["g"])("button",{style:{background:"var(--danger)"},onClick:t[2]||(t[2]=function(t){return e.cancel()}),class:"action-button"}," Cancelar ")])])):Object(a["e"])("",!0)],64)})),l=n("5c40"),u=n("c2de"),d=Object(l["l"])({components:{Backdrop:u["a"]},props:{show:{type:Boolean,required:!0},title:{type:String,required:!1},fixed:{type:Boolean,required:!1,default:!1},error:{type:Boolean,required:!0},loading:{type:Boolean,required:!0},massiveDelete:{type:Boolean,required:!1}},emits:["confirmMassive","close","confirm","cancel"],methods:{tryClose:function(){this.$emit("close")},confirm:function(){this.massiveDelete?this.$emit("confirmMassive"):this.$emit("confirm")},cancel:function(){this.$emit("cancel")}}});n("aa14");d.render=s,d.__scopeId="data-v-ea440b04";t["a"]=d},b887:function(e,t,n){},d81d:function(e,t,n){"use strict";var a=n("23e7"),r=n("b727").map,o=n("1dde"),c=o("map");a({target:"Array",proto:!0,forced:!c},{map:function(e){return r(this,e,arguments.length>1?arguments[1]:void 0)}})},ecd5:function(e,t,n){"use strict";n("53c6")}}]);
//# sourceMappingURL=chunk-1d377684.d33b5bb9.js.map