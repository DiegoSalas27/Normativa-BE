(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-eee5249a"],{"0cb2":function(e,t,a){var n=a("7b0b"),r=Math.floor,c="".replace,o=/\$([$&'`]|\d{1,2}|<[^>]*>)/g,i=/\$([$&'`]|\d{1,2})/g;e.exports=function(e,t,a,s,u,l){var d=a+e.length,f=s.length,p=i;return void 0!==u&&(u=n(u),p=o),c.call(l,p,(function(n,c){var o;switch(c.charAt(0)){case"$":return"$";case"&":return e;case"`":return t.slice(0,a);case"'":return t.slice(d);case"<":o=u[c.slice(1,-1)];break;default:var i=+c;if(0===i)return n;if(i>f){var l=r(i/10);return 0===l?n:l<=f?void 0===s[l-1]?c.charAt(1):s[l-1]+c.charAt(1):n}o=s[i-1]}return void 0===o?"":o}))}},"107c":function(e,t,a){var n=a("d039");e.exports=n((function(){var e=RegExp("(?<a>b)","string".charAt(5));return"b"!==e.exec("b").groups.a||"bc"!=="b".replace(e,"$<a>c")}))},"14c3":function(e,t,a){var n=a("c6b6"),r=a("9263");e.exports=function(e,t){var a=e.exec;if("function"===typeof a){var c=a.call(e,t);if("object"!==typeof c)throw TypeError("RegExp exec method returned something other than an Object or null");return c}if("RegExp"!==n(e))throw TypeError("RegExp#exec called on incompatible receiver");return r.call(e,t)}},3108:function(e,t,a){"use strict";a.r(t);var n=a("7a23"),r=Object(n["W"])("data-v-3cae37c4");Object(n["E"])("data-v-3cae37c4");var c=Object(n["m"])("i",{class:"fas fa-chevron-left"},null,-1),o=Object(n["l"])(" Salir "),i={class:"buttons"};Object(n["C"])();var s=r((function(e,t,a,r,s,u){var l=Object(n["J"])("confirmation-modal"),d=Object(n["J"])("modal"),f=Object(n["J"])("grid");return Object(n["B"])(),Object(n["j"])("div",null,[Object(n["m"])(l,{error:null,show:e.showModalConfirmation,title:e.modalTitle,massiveDelete:e.massiveDelete,onConfirm:e.confirmDelete,onConfirmMassive:e.confirmMassiveDelete,onCancel:e.closeModal},null,8,["show","title","massiveDelete","onConfirm","onConfirmMassive","onCancel"]),Object(n["m"])(d,{show:!!e.message,title:e.message,onClose:e.handleError,error:e.error,loading:e.loading},null,8,["show","title","onClose","error","loading"]),Object(n["m"])("section",{id:"main",class:{expand:e.expand}},[Object(n["m"])("h3",{class:"back",onClick:t[1]||(t[1]=function(){return e.goBack&&e.goBack.apply(e,arguments)})},[c,o]),Object(n["m"])("h2",null,"REPORTE DE "+Object(n["L"])(e.calculateReport()),1),Object(n["m"])("div",i,[e.isAnalista||e.isJefeRiesgos||e.isEspecialista?(Object(n["B"])(),Object(n["j"])("button",{key:0,class:"action-button",onClick:t[2]||(t[2]=function(t){return e.deleteMassive()})}," Eliminación masiva ")):Object(n["k"])("",!0)]),Object(n["m"])(f,{dataSource:e.dataSource,columns:e.columns,config:e.config,actions:e.actions,rows:5,onMovePage:e.movePage,onSelectedList:e.selectedList},null,8,["dataSource","columns","config","actions","onMovePage","onSelectedList"])],2)])})),u=a("1da1"),l=(a("96cf"),a("ac1f"),a("5319"),a("d3b7"),a("3ca3"),a("ddb0"),a("d81d"),a("99af"),a("9fbc")),d=a("5c40"),f=a("f50d"),p=a("2fc2"),h=a("b7ff"),m=a("705f"),b=a("d43e"),g=a("3e2f"),v=Object(d["p"])({components:{Grid:l["a"],ConfirmationModal:h["a"],Modal:m["a"]},data:function(){return{userInfoJson:Object(b["h"])(),columns:{},dataSource:Object(b["a"])(),isAnalista:!1,isJefeRiesgos:!1,isEspecialista:!1,config:{deleteEntity:"",entity:p["n"].EVALUACION},actions:[{icon:"fas fa-trash-alt",type:p["e"].DELETE,method:this.delete},{icon:"fas fa-eye",type:p["e"].EDIT,method:this.edit}],modalTitle:"",showModalConfirmation:!1,id:"",entity:"",message:null,loading:!1,error:!1,massiveDelete:!1,expand:!1,url:"",page:1,quantity:5,entityList:[],type:""}},mounted:function(){var e=this;this.type=this.$route.params.type,Object(u["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:if(e.$route.params.type){t.next=6;break}t.t0=e.$route.path,t.next="/dashboard/listas-verificacion"===t.t0?4:6;break;case 4:return e.type="ListasVerificacion",t.abrupt("break",6);case 6:return t.next=8,Object(f["a"])();case 8:e.userInfoJson=t.sent,t.t1=e.type,t.next="ListasVerificacion"===t.t1?12:"PlanesTratamiento"===t.t1?20:"RiesgoNormativa"===t.t1?30:"Evaluacion"===t.t1?37:47;break;case 12:return e.userInfoJson.rol==p["p"].ESPECIALISTA&&(e.isEspecialista=!0),e.columns=p["g"],e.url="listas-verificacion",e.$router.replace(e.url),e.actions=[{icon:"fas fa-trash-alt",type:p["e"].DELETE,method:e.delete},{icon:"fas fa-pen",type:p["e"].EDIT,method:e.edit}],t.next=19,e.listListaVerificacion();case 19:return t.abrupt("break",52);case 20:return e.columns=p["h"],e.dataSource={listaRecords:g["c"],numeroPaginas:0,totalRecords:0},e.url="/plan-tratamiento/",t.next=25,Object(f["a"])();case 25:return e.userInfoJson=t.sent,e.userInfoJson.rol==p["p"].JEFE_DE_RIESGOS?(e.isJefeRiesgos=!0,e.actions=[{icon:"fas fa-trash-alt",type:p["e"].DELETE,method:e.delete},{icon:"fas fa-eye",type:p["e"].EDIT,method:e.editEvaluaciones}]):e.actions=[{icon:"fas fa-eye",type:p["e"].EDIT,method:e.editEvaluaciones}],t.next=29,e.listPlanTratamiento();case 29:return t.abrupt("break",52);case 30:return e.columns=p["j"],e.dataSource={listaRecords:g["b"],numeroPaginas:0,totalRecords:0},e.url="/evaluacion/",e.actions=[{icon:"fas fa-eye",type:p["e"].EDIT,method:e.editRiesgoNormativa}],t.next=36,e.listRiesgoNormativa();case 36:return t.abrupt("break",52);case 37:return e.columns=p["f"],e.dataSource={listaRecords:g["a"],numeroPaginas:0,totalRecords:0},e.url="/evaluacion/",t.next=42,Object(f["a"])();case 42:return e.userInfoJson=t.sent,e.userInfoJson.rol==p["p"].ANALISTA?(e.isAnalista=!0,e.actions=[{icon:"fas fa-trash-alt",type:p["e"].DELETE,method:e.delete},{icon:"fas fa-eye",type:p["e"].EDIT,method:e.editEvaluaciones}]):e.actions=[{icon:"fas fa-eye",type:p["e"].EDIT,method:e.editEvaluaciones}],t.next=46,e.listEvaluacion();case 46:return t.abrupt("break",52);case 47:return e.columns=p["h"],e.actions=[{icon:"fas fa-eye",type:p["e"].EDIT,method:e.editPlanTratamiento}],t.next=51,e.listPlanTratamiento();case 51:return t.abrupt("break",52);case 52:case"end":return t.stop()}}),t)})))()},methods:{movePage:function(e){switch(this.page=e,this.type){case"PlanesTratamiento":this.listPlanTratamiento();break;case"Evaluacion":this.listEvaluacion()}},goBack:function(){this.$router.back()},selectedList:function(e){this.entityList=e},expandMain:function(e){this.expand=!e},handleError:function(){this.message=null},closeModal:function(){this.showModalConfirmation=!1},calculateReport:function(){if(!this.$route.params.type)switch(this.$route.path){case"/dashboard/listas-verificacion":this.type="ListasVerificacion";break}switch(this.type){case"PlanesTratamiento":return"PLANES DE TRATAMIENTO";case"RiesgoNormativa":return"CUMPLIMIENTO POR LISTA DE VERIFICACIÓN";case"Evaluacion":return"RESULTADOS DE EVALUACIONES";case"ListasVerificacion":return"LISTAS DE VERIFICACIÓN"}},editPlanTratamiento:function(e,t,a){this.$router.push(this.url+t)},deleteRiesgoNormativa:function(){console.log("deleteRiesgoNormativa")},editRiesgoNormativa:function(e,t,a){console.log("editRiesgoNormativa"),this.$router.push(this.url+t)},deleteEvaluaciones:function(){console.log("deleteEvaluaciones")},deleteMassive:function(){this.entityList.length>0?(this.massiveDelete=!0,this.showModalConfirmation=!0,this.modalTitle="Esta acción eliminara las dependencias de los items seleccionados,¿continuar?"):(this.message="Debe seleccionar al menos un item",this.error=!0),this.page=1},edit:function(e,t,a){this.$router.push("/dashboard/"+this.url+"/"+t)},delete:function(e,t,a){switch(this.id=e,this.type){case"PlanesTratamiento":this.modalTitle="¿Está seguro que desea eliminar el tratamiento ?";break;case"Evaluacion":this.modalTitle="¿Está seguro que desea eliminar la evaluación ?";break;case"ListasVerificacion":this.modalTitle="¿Está seguro que desea eliminar la lista de verificación?";break}this.entity=a,this.showModalConfirmation=!0,this.page=1},editEvaluaciones:function(e,t,a){console.log("editEvaluaciones"),this.$router.push(this.url+t)},confirmMassiveDelete:function(){var e=this;return Object(u["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:console.log(e.type),t.t0=e.type,t.next="PlanesTratamiento"===t.t0?5:"Evaluacion"===t.t0?9:"ListasVerificacion"===t.t0?13:15;break;case 5:return console.log(e.entityList),t.next=8,Promise.all(e.entityList.map(function(){var e=Object(u["a"])(regeneratorRuntime.mark((function e(t){return regeneratorRuntime.wrap((function(e){while(1)switch(e.prev=e.next){case 0:return e.prev=0,e.next=3,fetch("".concat(p["c"],"plantratamiento/").concat(t),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:e.sent,e.next=9;break;case 6:e.prev=6,e.t0=e["catch"](0),console.log(e.t0);case 9:case"end":return e.stop()}}),e,null,[[0,6]])})));return function(t){return e.apply(this,arguments)}}()));case 8:return t.abrupt("break",15);case 9:return console.log(e.entityList),t.next=12,Promise.all(e.entityList.map(function(){var e=Object(u["a"])(regeneratorRuntime.mark((function e(t){return regeneratorRuntime.wrap((function(e){while(1)switch(e.prev=e.next){case 0:return e.prev=0,e.next=3,fetch("".concat(p["c"],"evaluacion/").concat(t),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:e.sent,e.next=9;break;case 6:e.prev=6,e.t0=e["catch"](0),console.log(e.t0);case 9:case"end":return e.stop()}}),e,null,[[0,6]])})));return function(t){return e.apply(this,arguments)}}()));case 12:return t.abrupt("break",15);case 13:return t.next=15,Promise.all(e.entityList.map(function(){var e=Object(u["a"])(regeneratorRuntime.mark((function e(t){return regeneratorRuntime.wrap((function(e){while(1)switch(e.prev=e.next){case 0:return e.prev=0,e.next=3,fetch("".concat(p["c"],"listaverificaciones/").concat(t),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:e.sent,e.next=9;break;case 6:e.prev=6,e.t0=e["catch"](0),console.log(e.t0);case 9:case"end":return e.stop()}}),e,null,[[0,6]])})));return function(t){return e.apply(this,arguments)}}()));case 15:e.massiveDelete=!1,e.showModalConfirmation=!1,e.modalTitle="",t.t1=e.type,t.next="PlanesTratamiento"===t.t1?21:"Evaluacion"===t.t1?23:"ListasVerificacion"===t.t1?25:27;break;case 21:return e.message="Los tratamientos  fueron eliminados",t.abrupt("break",27);case 23:return e.message="Las evaluaciones  fueron eliminadas",t.abrupt("break",27);case 25:return e.message="Las listas de verificación fueron eliminadas",t.abrupt("break",27);case 27:setTimeout(Object(u["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:t.t0=e.type,t.next="PlanesTratamiento"===t.t0?3:"Evaluacion"===t.t0?6:"ListasVerificacion"===t.t0?9:12;break;case 3:return t.next=5,e.listPlanTratamiento();case 5:return t.abrupt("break",12);case 6:return t.next=8,e.listEvaluacion();case 8:return t.abrupt("break",12);case 9:return t.next=11,e.listListaVerificacion();case 11:return t.abrupt("break",12);case 12:e.message=null;case 13:case"end":return t.stop()}}),t)}))),2e3);case 28:case"end":return t.stop()}}),t)})))()},listListaVerificacion:function(){var e=this;return Object(u["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(p["c"],"listaverificaciones/listar?page=").concat(e.page,"&quantity=").concat(e.quantity),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return a=t.sent,t.next=6,a.json();case 6:e.dataSource=t.sent,t.next=12;break;case 9:t.prev=9,t.t0=t["catch"](0),console.log(t.t0);case 12:case"end":return t.stop()}}),t,null,[[0,9]])})))()},listPlanTratamiento:function(){var e=this;return Object(u["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(p["c"],"plantratamiento/lista?page=").concat(e.page,"&quantity=").concat(e.quantity),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return a=t.sent,t.next=6,a.json();case 6:e.dataSource=t.sent,t.next=12;break;case 9:t.prev=9,t.t0=t["catch"](0),console.log(t.t0);case 12:case"end":return t.stop()}}),t,null,[[0,9]])})))()},listRiesgoNormativa:function(){var e=this;return Object(u["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(p["c"],"evaluacion/listado?page=").concat(e.page,"&quantity=").concat(e.quantity),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return a=t.sent,t.next=6,a.json();case 6:e.dataSource=t.sent,t.next=12;break;case 9:t.prev=9,t.t0=t["catch"](0),console.log(t.t0);case 12:case"end":return t.stop()}}),t,null,[[0,9]])})))()},confirmDelete:function(){var e=this;return Object(u["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:e.closeModal(),t.t0=e.type,t.next="PlanesTratamiento"===t.t0?4:"Evaluacion"===t.t0?18:"ListasVerificacion"===t.t0?32:46;break;case 4:return t.prev=4,t.next=7,fetch("".concat(p["c"],"plantratamiento/").concat(e.id),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 7:t.sent,e.message="El tratamiento fue eliminado",e.id="",e.entity="",setTimeout(Object(u["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.listPlanTratamiento();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3),t.next=17;break;case 14:t.prev=14,t.t1=t["catch"](4),console.log(t.t1);case 17:return t.abrupt("break",46);case 18:return t.prev=18,t.next=21,fetch("".concat(p["c"],"evaluacion/").concat(e.id),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 21:t.sent,e.message="La evaluación fue eliminada",e.id="",e.entity="",setTimeout(Object(u["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.listEvaluacion();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3),t.next=31;break;case 28:t.prev=28,t.t2=t["catch"](18),console.log(t.t2);case 31:return t.abrupt("break",46);case 32:return t.prev=32,t.next=35,fetch("".concat(p["c"],"listaverificaciones/").concat(e.id),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 35:t.sent,e.message="La lista de verificación fue eliminada",e.id="",e.entity="",setTimeout(Object(u["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.listListaVerificacion();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3),t.next=45;break;case 42:t.prev=42,t.t3=t["catch"](32),console.log(t.t3);case 45:return t.abrupt("break",46);case 46:case"end":return t.stop()}}),t,null,[[4,14],[18,28],[32,42]])})))()},listEvaluacion:function(){var e=this;return Object(u["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(p["c"],"evaluacion/listado?page=").concat(e.page,"&quantity=").concat(e.quantity),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return a=t.sent,console.log("this.dataSource"),console.log(e.dataSource),t.next=8,a.json();case 8:e.dataSource=t.sent,console.log("this.dataSource"),console.log(e.dataSource),t.next=16;break;case 13:t.prev=13,t.t0=t["catch"](0),console.log(t.t0);case 16:case"end":return t.stop()}}),t,null,[[0,13]])})))()}}}),j=(a("318e"),a("d959")),y=a.n(j);const x=y()(v,[["render",s],["__scopeId","data-v-3cae37c4"]]);t["default"]=x},"318e":function(e,t,a){"use strict";a("7e13")},"38b4":function(e,t,a){"use strict";a("c016")},"3e2f":function(e,t,a){"use strict";a.d(t,"e",(function(){return n})),a.d(t,"f",(function(){return r})),a.d(t,"d",(function(){return c})),a.d(t,"c",(function(){return o})),a.d(t,"a",(function(){return i})),a.d(t,"b",(function(){return s}));var n=[{name:"High - 2013",data:[12,29,33,36,32,32,33]},{name:"Low - 2013",data:[28,11,14,18,17,13,13]}],r=[{data:[{x:"New Delhi",y:218},{x:"Kolkata",y:149},{x:"Mumbai",y:184},{x:"Ahmedabad",y:55},{x:"Bangaluru",y:84},{x:"Pune",y:31},{x:"Chennai",y:70},{x:"Jaipur",y:30},{x:"Surat",y:44},{x:"Hyderabad",y:68},{x:"Lucknow",y:28},{x:"Indore",y:19},{x:"Kanpur",y:29}]}],c={listaRecords:[],numeroPaginas:1,totalRecords:0},o=[{codigo:"TR001",fechaInicio:"05/06/2021",fechaFin:"11/06/2021",estado:"Solucionado",evaluacion:"EV001-Departamento Bohem",responsable:"Luis Quispe"},{codigo:"TR002",fechaInicio:"01/01/2021",fechaFin:"07/01/2021",estado:"Asignado",evaluacion:"EV002-Departamento Plaza 27",responsable:"Marcelo Lopez"}],i=[{codigo:"EV001",obra:"OB001-Departamento Bohem",nivelRiesgo:"Bajo",porcentajeCumplimiento:"30%",duracion:"12"},{codigo:"EV002",obra:"OB002-Departamento Plaza 27",nivelRiesgo:"Medio",porcentajeCumplimiento:"60%",duracion:"24"}],s=[{normativa:"29783",codigoEvaluacion:"EV001",evaluacion:"Evaluacion de elementos de seguridad",nivelRiesgo:"Medio",fechaCreacion:"15/05/2021"},{normativa:"ISO 45001",codigoEvaluacion:"EV002",evaluacion:"Evaluacion de elementos peligrosos",nivelRiesgo:"Bajo",fechaCreacion:"25/05/2021"}]},5319:function(e,t,a){"use strict";var n=a("d784"),r=a("d039"),c=a("825a"),o=a("50c4"),i=a("a691"),s=a("1d80"),u=a("8aa5"),l=a("0cb2"),d=a("14c3"),f=a("b622"),p=f("replace"),h=Math.max,m=Math.min,b=function(e){return void 0===e?e:String(e)},g=function(){return"$0"==="a".replace(/./,"$0")}(),v=function(){return!!/./[p]&&""===/./[p]("a","$0")}(),j=!r((function(){var e=/./;return e.exec=function(){var e=[];return e.groups={a:"7"},e},"7"!=="".replace(e,"$<a>")}));n("replace",(function(e,t,a){var n=v?"$":"$0";return[function(e,a){var n=s(this),r=void 0==e?void 0:e[p];return void 0!==r?r.call(e,n,a):t.call(String(n),e,a)},function(e,r){if("string"===typeof r&&-1===r.indexOf(n)&&-1===r.indexOf("$<")){var s=a(t,this,e,r);if(s.done)return s.value}var f=c(this),p=String(e),g="function"===typeof r;g||(r=String(r));var v=f.global;if(v){var j=f.unicode;f.lastIndex=0}var y=[];while(1){var x=d(f,p);if(null===x)break;if(y.push(x),!v)break;var O=String(x[0]);""===O&&(f.lastIndex=u(p,o(f.lastIndex),j))}for(var E="",k=0,w=0;w<y.length;w++){x=y[w];for(var R=String(x[0]),S=h(m(i(x.index),p.length),0),I=[],T=1;T<x.length;T++)I.push(b(x[T]));var C=x.groups;if(g){var L=[R].concat(I,S,p);void 0!==C&&L.push(C);var A=String(r.apply(void 0,L))}else A=l(R,p,S,I,C,r);S>=k&&(E+=p.slice(k,S)+A,k=S+R.length)}return E+p.slice(k)}]}),!j||!g||v)},5899:function(e,t){e.exports="\t\n\v\f\r                　\u2028\u2029\ufeff"},"58a8":function(e,t,a){var n=a("1d80"),r=a("5899"),c="["+r+"]",o=RegExp("^"+c+c+"*"),i=RegExp(c+c+"*$"),s=function(e){return function(t){var a=String(n(t));return 1&e&&(a=a.replace(o,"")),2&e&&(a=a.replace(i,"")),a}};e.exports={start:s(1),end:s(2),trim:s(3)}},"682b":function(e,t,a){"use strict";function n(e){var t=new Date(e),a=Date.now()-t.getTime(),n=new Date(a);return Math.abs(n.getUTCFullYear()-1970)}a.d(t,"a",(function(){return n}))},7156:function(e,t,a){var n=a("861d"),r=a("d2bb");e.exports=function(e,t,a){var c,o;return r&&"function"==typeof(c=t.constructor)&&c!==a&&n(o=c.prototype)&&o!==a.prototype&&r(e,o),e}},"7e13":function(e,t,a){},"8aa5":function(e,t,a){"use strict";var n=a("6547").charAt;e.exports=function(e,t,a){return t+(a?n(e,t).length:1)}},9263:function(e,t,a){"use strict";var n=a("ad6d"),r=a("9f7f"),c=a("5692"),o=a("7c73"),i=a("69f3").get,s=a("fce3"),u=a("107c"),l=RegExp.prototype.exec,d=c("native-string-replace",String.prototype.replace),f=l,p=function(){var e=/a/,t=/b*/g;return l.call(e,"a"),l.call(t,"a"),0!==e.lastIndex||0!==t.lastIndex}(),h=r.UNSUPPORTED_Y||r.BROKEN_CARET,m=void 0!==/()??/.exec("")[1],b=p||m||h||s||u;b&&(f=function(e){var t,a,r,c,s,u,b,g=this,v=i(g),j=v.raw;if(j)return j.lastIndex=g.lastIndex,t=f.call(j,e),g.lastIndex=j.lastIndex,t;var y=v.groups,x=h&&g.sticky,O=n.call(g),E=g.source,k=0,w=e;if(x&&(O=O.replace("y",""),-1===O.indexOf("g")&&(O+="g"),w=String(e).slice(g.lastIndex),g.lastIndex>0&&(!g.multiline||g.multiline&&"\n"!==e[g.lastIndex-1])&&(E="(?: "+E+")",w=" "+w,k++),a=new RegExp("^(?:"+E+")",O)),m&&(a=new RegExp("^"+E+"$(?!\\s)",O)),p&&(r=g.lastIndex),c=l.call(x?a:g,w),x?c?(c.input=c.input.slice(k),c[0]=c[0].slice(k),c.index=g.lastIndex,g.lastIndex+=c[0].length):g.lastIndex=0:p&&c&&(g.lastIndex=g.global?c.index+c[0].length:r),m&&c&&c.length>1&&d.call(c[0],a,(function(){for(s=1;s<arguments.length-2;s++)void 0===arguments[s]&&(c[s]=void 0)})),c&&y)for(c.groups=u=o(null),s=0;s<y.length;s++)b=y[s],u[b[0]]=c[b[1]];return c}),e.exports=f},"9f7f":function(e,t,a){var n=a("d039"),r=function(e,t){return RegExp(e,t)};t.UNSUPPORTED_Y=n((function(){var e=r("a","y");return e.lastIndex=2,null!=e.exec("abcd")})),t.BROKEN_CARET=n((function(){var e=r("^r","gy");return e.lastIndex=2,null!=e.exec("str")}))},"9fbc":function(e,t,a){"use strict";var n=a("7a23"),r=Object(n["W"])("data-v-30baf8dd");Object(n["E"])("data-v-30baf8dd");var c={class:"grid"},o={key:0},i={key:1},s={key:0},u=Object(n["m"])("br",null,null,-1),l={key:0},d={key:1,class:"no-data"},f={key:0},p={key:1},h={key:0};Object(n["C"])();var m=r((function(e,t,a,r,m,b){var g,v,j;return Object(n["B"])(),Object(n["j"])(n["b"],null,[Object(n["m"])("table",c,[Object(n["m"])("thead",{class:e.rowHeaderStyle?"".concat(e.rowHeaderStyle," header-grid"):"header-grid"},[Object(n["m"])("tr",null,[(null===(g=e.actions)||void 0===g?void 0:g.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(n["B"])(),Object(n["j"])("th",o,[Object(n["U"])(Object(n["m"])("input",{type:"checkbox",id:"checkbox","onUpdate:modelValue":t[1]||(t[1]=function(t){return e.massiveCheck=t})},null,512),[[n["N"],e.massiveCheck]])])):Object(n["k"])("",!0),(Object(n["B"])(!0),Object(n["j"])(n["b"],null,Object(n["H"])(e.columns,(function(e){return Object(n["B"])(),Object(n["j"])("th",{key:e.field,style:{textAlign:e.align?e.align:"left"}},Object(n["L"])(e.title),5)})),128)),(null===(v=e.actions)||void 0===v?void 0:v.length)>0?(Object(n["B"])(),Object(n["j"])("th",i,"Acciones")):Object(n["k"])("",!0)])],2),e.dataSource.listaRecords&&0===(null===(j=e.dataSource.listaRecords)||void 0===j?void 0:j.length)?(Object(n["B"])(),Object(n["j"])("div",s,[u,e.rowBodyStyle?(Object(n["B"])(),Object(n["j"])("p",d,"Sin registros")):(Object(n["B"])(),Object(n["j"])("h3",l,"No hay datos registrados"))])):Object(n["k"])("",!0),Object(n["m"])("tbody",{class:e.rowBodyStyle?e.rowBodyStyle:""},[(Object(n["B"])(!0),Object(n["j"])(n["b"],null,Object(n["H"])(e.rows,(function(a,r){var c,o;return Object(n["B"])(),Object(n["j"])("tr",{key:a},[(null===(c=e.actions)||void 0===c?void 0:c.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(n["B"])(),Object(n["j"])("td",f,[e.dataSource.listaRecords&&e.dataSource.listaRecords[r]?Object(n["U"])((Object(n["B"])(),Object(n["j"])("input",{key:0,type:"checkbox",id:e.dataSource.listaRecords[r].id,value:e.dataSource.listaRecords[r].id,"onUpdate:modelValue":t[2]||(t[2]=function(t){return e.checkedEntities=t})},null,8,["id","value"])),[[n["N"],e.checkedEntities]]):Object(n["k"])("",!0)])):Object(n["k"])("",!0),(Object(n["B"])(!0),Object(n["j"])(n["b"],null,Object(n["H"])(e.columns,(function(t){return Object(n["B"])(),Object(n["j"])("td",{key:t.field},[Object(n["m"])("p",{style:{textAlign:t.align?t.align:"left"}},Object(n["L"])(e.getValue(t.field,e.dataSource.listaRecords,a-1,t.type)),5)])})),128)),(null===(o=e.actions)||void 0===o?void 0:o.length)>0?(Object(n["B"])(),Object(n["j"])("td",p,[(Object(n["B"])(!0),Object(n["j"])(n["b"],null,Object(n["H"])(e.actions,(function(t){return Object(n["B"])(),Object(n["j"])("span",{key:t.type},[e.dataSource.listaRecords[r]?(Object(n["B"])(),Object(n["j"])("i",{key:0,class:t.icon,style:{"margin-left":"18px"},onClick:function(a){return t.method(e.dataSource.listaRecords[r].id,e.dataSource.listaRecords[r].codigo,e.dataSource.listaRecords[r].entity)}},null,10,["onClick"])):Object(n["k"])("",!0)])})),128))])):Object(n["k"])("",!0)])})),128))],2)]),e.dataSource.numeroPaginas>1?(Object(n["B"])(),Object(n["j"])("div",h,[(Object(n["B"])(!0),Object(n["j"])(n["b"],null,Object(n["H"])(e.dataSource.numeroPaginas,(function(t){return Object(n["B"])(),Object(n["j"])("div",{key:t,class:"pageButton",onClick:function(a){return e.goPage(t)}},Object(n["L"])(t),9,["onClick"])})),128))])):Object(n["k"])("",!0)],64)})),b=(a("a9e3"),a("d81d"),a("682b")),g=a("5c40"),v=a("d4ec"),j=function e(t,a,n){Object(v["a"])(this,e),this.listaRecords=t,this.numeroPaginas=a,this.totalRecords=n},y=Object(g["p"])({props:{columns:{type:Array,required:!0},dataSource:{type:j,required:!0},config:{type:null,required:!1},actions:{type:null,required:!1,default:[]},method:{type:Function,required:!1},rows:{type:Number,required:!1,default:5},pages:{type:Number,required:!0},rowHeaderStyle:{type:String,required:!1},rowBodyStyle:{type:String,required:!1}},emits:["selectedList","movePage"],data:function(){return{massiveCheck:!1,checkedEntities:[]}},watch:{massiveCheck:function(){this.massiveCheck?this.checkedEntities=this.dataSource.listaRecords.map((function(e){return e.id})):this.checkedEntities=[]},checkedEntities:function(){this.$emit("selectedList",this.checkedEntities)}},methods:{goPage:function(e){this.$emit("movePage",e)},getValue:function(e,t,a,n){if(t)return t[a]?"fechaNacimiento"===e?Object(b["a"])(t[a][e]):"date"===n?new Date(t[a][e]).toLocaleDateString():t[a][e]:""}}}),x=(a("38b4"),a("d959")),O=a.n(x);const E=O()(y,[["render",m],["__scopeId","data-v-30baf8dd"]]);t["a"]=E},a1f3:function(e,t,a){},a9e3:function(e,t,a){"use strict";var n=a("83ab"),r=a("da84"),c=a("94ca"),o=a("6eeb"),i=a("5135"),s=a("c6b6"),u=a("7156"),l=a("c04e"),d=a("d039"),f=a("7c73"),p=a("241c").f,h=a("06cf").f,m=a("9bf2").f,b=a("58a8").trim,g="Number",v=r[g],j=v.prototype,y=s(f(j))==g,x=function(e){var t,a,n,r,c,o,i,s,u=l(e,!1);if("string"==typeof u&&u.length>2)if(u=b(u),t=u.charCodeAt(0),43===t||45===t){if(a=u.charCodeAt(2),88===a||120===a)return NaN}else if(48===t){switch(u.charCodeAt(1)){case 66:case 98:n=2,r=49;break;case 79:case 111:n=8,r=55;break;default:return+u}for(c=u.slice(2),o=c.length,i=0;i<o;i++)if(s=c.charCodeAt(i),s<48||s>r)return NaN;return parseInt(c,n)}return+u};if(c(g,!v(" 0o1")||!v("0b1")||v("+0x1"))){for(var O,E=function(e){var t=arguments.length<1?0:e,a=this;return a instanceof E&&(y?d((function(){j.valueOf.call(a)})):s(a)!=g)?u(new v(x(t)),a,E):x(t)},k=n?p(v):"MAX_VALUE,MIN_VALUE,NaN,NEGATIVE_INFINITY,POSITIVE_INFINITY,EPSILON,isFinite,isInteger,isNaN,isSafeInteger,MAX_SAFE_INTEGER,MIN_SAFE_INTEGER,parseFloat,parseInt,isInteger,fromString,range".split(","),w=0;k.length>w;w++)i(v,O=k[w])&&!i(E,O)&&m(E,O,h(v,O));E.prototype=j,j.constructor=E,o(r,g,E)}},aa14:function(e,t,a){"use strict";a("a1f3")},ac1f:function(e,t,a){"use strict";var n=a("23e7"),r=a("9263");n({target:"RegExp",proto:!0,forced:/./.exec!==r},{exec:r})},ad6d:function(e,t,a){"use strict";var n=a("825a");e.exports=function(){var e=n(this),t="";return e.global&&(t+="g"),e.ignoreCase&&(t+="i"),e.multiline&&(t+="m"),e.dotAll&&(t+="s"),e.unicode&&(t+="u"),e.sticky&&(t+="y"),t}},b7ff:function(e,t,a){"use strict";var n=a("7a23"),r=Object(n["W"])("data-v-ea440b04");Object(n["E"])("data-v-ea440b04");var c={key:0,class:"modal"},o=Object(n["m"])("i",{class:"far fa-times-circle fa-2x"},null,-1),i={class:"flex-button"};Object(n["C"])();var s=r((function(e,t,a,r,s,u){var l=Object(n["J"])("backdrop");return Object(n["B"])(),Object(n["j"])(n["b"],null,[Object(n["m"])(l,{show:e.show,onClose:e.tryClose,closable:!1},null,8,["show","onClose"]),e.show?(Object(n["B"])(),Object(n["j"])("div",c,[o,Object(n["m"])("p",null,Object(n["L"])(e.title),1),Object(n["m"])("div",i,[Object(n["m"])("button",{onClick:t[1]||(t[1]=function(t){return e.confirm()}),class:"action-button"},"Aceptar"),Object(n["m"])("button",{style:{background:"var(--danger)"},onClick:t[2]||(t[2]=function(t){return e.cancel()}),class:"action-button"}," Cancelar ")])])):Object(n["k"])("",!0)],64)})),u=a("5c40"),l=a("c2de"),d=Object(u["p"])({components:{Backdrop:l["a"]},props:{show:{type:Boolean,required:!0},title:{type:String,required:!1},fixed:{type:Boolean,required:!1,default:!1},error:{type:Boolean,required:!0},loading:{type:Boolean,required:!0},massiveDelete:{type:Boolean,required:!1}},emits:["confirmMassive","close","confirm","cancel"],methods:{tryClose:function(){this.$emit("close")},confirm:function(){this.massiveDelete?this.$emit("confirmMassive"):this.$emit("confirm")},cancel:function(){this.$emit("cancel")}}}),f=(a("aa14"),a("d959")),p=a.n(f);const h=p()(d,[["render",s],["__scopeId","data-v-ea440b04"]]);t["a"]=h},c016:function(e,t,a){},d784:function(e,t,a){"use strict";a("ac1f");var n=a("6eeb"),r=a("9263"),c=a("d039"),o=a("b622"),i=a("9112"),s=o("species"),u=RegExp.prototype;e.exports=function(e,t,a,l){var d=o(e),f=!c((function(){var t={};return t[d]=function(){return 7},7!=""[e](t)})),p=f&&!c((function(){var t=!1,a=/a/;return"split"===e&&(a={},a.constructor={},a.constructor[s]=function(){return a},a.flags="",a[d]=/./[d]),a.exec=function(){return t=!0,null},a[d](""),!t}));if(!f||!p||a){var h=/./[d],m=t(d,""[e],(function(e,t,a,n,c){var o=t.exec;return o===r||o===u.exec?f&&!c?{done:!0,value:h.call(t,a,n)}:{done:!0,value:e.call(a,t,n)}:{done:!1}}));n(String.prototype,e,m[0]),n(u,d,m[1])}l&&i(u[d],"sham",!0)}},d81d:function(e,t,a){"use strict";var n=a("23e7"),r=a("b727").map,c=a("1dde"),o=c("map");n({target:"Array",proto:!0,forced:!o},{map:function(e){return r(this,e,arguments.length>1?arguments[1]:void 0)}})},f50d:function(e,t,a){"use strict";a.d(t,"a",(function(){return c}));var n=a("1da1"),r=(a("96cf"),a("d3b7"),a("2fc2"));function c(){return o.apply(this,arguments)}function o(){return o=Object(n["a"])(regeneratorRuntime.mark((function e(){var t,a;return regeneratorRuntime.wrap((function(e){while(1)switch(e.prev=e.next){case 0:return e.next=2,fetch("".concat(r["c"],"usuario"),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 2:return t=e.sent,e.next=5,t.json();case 5:return a=e.sent,e.abrupt("return",a);case 7:case"end":return e.stop()}}),e)}))),o.apply(this,arguments)}},fce3:function(e,t,a){var n=a("d039");e.exports=n((function(){var e=RegExp(".","string".charAt(0));return!(e.dotAll&&e.exec("\n")&&"s"===e.flags)}))}}]);
//# sourceMappingURL=chunk-eee5249a.ea1ec445.js.map