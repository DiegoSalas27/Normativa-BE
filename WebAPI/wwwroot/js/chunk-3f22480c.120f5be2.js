(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-3f22480c"],{"0609":function(e,t,a){"use strict";a("9d17")},"0a17":function(e,t,a){},"0aec":function(e,t,a){},"25f0":function(e,t,a){"use strict";var n=a("6eeb"),i=a("825a"),c=a("d039"),o=a("ad6d"),r="toString",s=RegExp.prototype,l=s[r],u=c((function(){return"/a/b"!=l.call({source:"a",flags:"b"})})),d=l.name!=r;(u||d)&&n(RegExp.prototype,r,(function(){var e=i(this),t=String(e.source),a=e.flags,n=String(void 0===a&&e instanceof RegExp&&!("flags"in s)?o.call(e):a);return"/"+t+"/"+n}),{unsafe:!0})},"3ce8":function(e,t,a){"use strict";a.r(t);var n=a("7a23"),i=a("1d35"),c=a.n(i),o=a("c3e0"),r=a.n(o),s=a("5f1f"),l=a.n(s),u=a("be24"),d=a.n(u),b=a("722d"),f=a.n(b),p=a("5b89"),g=a.n(p),h=a("2f97"),m=a.n(h),v=Object(n["J"])("data-v-264760ea");Object(n["s"])("data-v-264760ea");var O={id:"main"},j=Object(n["g"])("h1",null,"Registrar evaluación de obra",-1),y={class:"flex-row"},w={class:"flex-col"},k={class:""},C=Object(n["g"])("h3",null,"Códidgo de evaluación",-1),x=Object(n["g"])("img",{src:c.a,alt:"codeva",class:"imgIcon"},null,-1),R={class:"non-editable"},E=Object(n["g"])("h3",null,"Seleccione lista de verificación",-1),S=Object(n["g"])("img",{src:r.a,alt:"listave",class:"imgIcon"},null,-1),I={key:0},T=Object(n["g"])("br",null,null,-1),V=Object(n["g"])("span",{style:{"font-weight":"bold"}},"Fecha de creación: ",-1),L=Object(n["g"])("br",null,null,-1),M=Object(n["g"])("span",{style:{"font-weight":"bold"}},"requerimientos: ",-1),D=Object(n["g"])("br",null,null,-1),B=Object(n["g"])("h3",null,"Código de obra",-1),A=Object(n["g"])("img",{src:c.a,alt:"codobra",class:"imgIcon"},null,-1),N=Object(n["g"])("h3",null,"Nombre",-1),P=Object(n["g"])("img",{src:l.a,alt:"nombre",class:"imgIcon"},null,-1),z=Object(n["g"])("h3",null,"Fecha de creación",-1),$=Object(n["g"])("img",{src:d.a,alt:"fecha",class:"imgIcon"},null,-1),q={class:"non-editable"},H={class:"flex-col"},G=Object(n["g"])("h3",null,"Estado",-1),_=Object(n["g"])("img",{src:f.a,alt:"estado",class:"imgIcon"},null,-1),U={class:"non-editable"},F=Object(n["g"])("img",{src:g.a,alt:"prueba",class:"imgIcon"},null,-1),J=Object(n["g"])("div",null,[Object(n["g"])("img",{src:m.a,alt:"obra"})],-1);Object(n["q"])();var K=v((function(e,t,a,i,c,o){var r,s,l,u=Object(n["x"])("nav-bar"),d=Object(n["x"])("confirmation-modal"),b=Object(n["x"])("modal"),f=Object(n["x"])("grid");return Object(n["p"])(),Object(n["d"])(n["a"],null,[Object(n["g"])(u,{name:null===(r=e.userInfoJson)||void 0===r?void 0:r.nombres,lastName:null===(s=e.userInfoJson)||void 0===s?void 0:s.apellidos},null,8,["name","lastName"]),Object(n["g"])(d,{error:null,show:e.showModalConfirmation,title:e.modalTitle,massiveDelete:e.massiveDelete,onConfirm:e.confirmDelete,onConfirmMassive:e.confirmMassiveDelete,onCancel:e.closeModal},null,8,["show","title","massiveDelete","onConfirm","onConfirmMassive","onCancel"]),Object(n["g"])(b,{show:!!e.message,title:e.message,onClose:e.handleError,error:e.error,loading:e.loading},null,8,["show","title","onClose","error","loading"]),Object(n["g"])("section",O,[j,Object(n["g"])("button",{class:e.$route.params.id?"action-button":"action-button blocked",disabled:!e.$route.params.id&&!e.verifyPruebaCompleta,onClick:t[1]||(t[1]=function(){return e.submit&&e.submit.apply(e,arguments)})},Object(n["z"])(e.evaluacion.visibilidad?"Editar":"Guardar"),11,["disabled"]),Object(n["g"])("div",y,[Object(n["g"])("div",w,[Object(n["g"])("div",k,[C,x,Object(n["g"])("div",R,Object(n["z"])(e.evaluacion.codigo),1)]),Object(n["g"])("div",null,[E,S,Object(n["H"])(Object(n["g"])("input",{type:"text",placeholder:"Ingrese lista de verificación",disabled:""!=e.$route.params.id&&void 0!=e.$route.params.id,onKeyup:t[2]||(t[2]=function(){return e.searchListaVerificacion&&e.searchListaVerificacion.apply(e,arguments)}),"onUpdate:modelValue":t[3]||(t[3]=function(t){return e.codigoListaVerificacion=t})},null,40,["disabled"]),[[n["E"],e.codigoListaVerificacion,void 0,{trim:!0}]]),(Object(n["p"])(!0),Object(n["d"])(n["a"],null,Object(n["v"])(e.listasVerificacion,(function(t){return Object(n["p"])(),Object(n["d"])("p",{class:"dropdownSelect",key:t.listaVerificacionId,onClick:function(a){return e.selectListaVerificacion(t)}},Object(n["z"])(t.codigo+"-"+t.nombre),9,["onClick"])})),128)),e.selectedListaVerificacion.fechaCreacion?(Object(n["p"])(),Object(n["d"])("div",I,[T,V,Object(n["g"])("span",null,Object(n["z"])(null===(l=new Date(e.selectedListaVerificacion.fechaCreacion))||void 0===l?void 0:l.toLocaleDateString()),1),L,Object(n["g"])("p",null,[M,Object(n["f"])(Object(n["z"])(e.selectedListaVerificacion.requerimientosCount),1)]),D])):Object(n["e"])("",!0)]),Object(n["g"])("div",null,[B,A,Object(n["H"])(Object(n["g"])("input",{type:"text",placeholder:"Ingrese código o nombre de obra",disabled:""!=e.$route.params.id&&void 0!=e.$route.params.id,onKeyup:t[4]||(t[4]=function(){return e.searchObra&&e.searchObra.apply(e,arguments)}),"onUpdate:modelValue":t[5]||(t[5]=function(t){return e.codigoObra=t})},null,40,["disabled"]),[[n["E"],e.codigoObra,void 0,{trim:!0}]]),(Object(n["p"])(!0),Object(n["d"])(n["a"],null,Object(n["v"])(e.obras,(function(t){return Object(n["p"])(),Object(n["d"])("p",{class:"dropdownSelect",key:t.obraId,onClick:function(a){return e.SelectObra(t)}},Object(n["z"])(t.codigo+"-"+t.nombre),9,["onClick"])})),128))]),Object(n["g"])("div",null,[N,P,Object(n["H"])(Object(n["g"])("input",{type:"text",placeholder:e.evaluacion.nombre,"onUpdate:modelValue":t[6]||(t[6]=function(t){return e.evaluacion.nombre=t})},null,8,["placeholder"]),[[n["E"],e.evaluacion.nombre,void 0,{trim:!0}]])]),Object(n["g"])("div",null,[z,$,Object(n["g"])("div",q,Object(n["z"])(e.evaluacion.fechaCreacion),1)])]),Object(n["g"])("div",H,[Object(n["g"])("div",null,[G,_,Object(n["g"])("div",U,Object(n["z"])(e.evaluacion.estado),1)]),Object(n["g"])("div",null,[F,Object(n["g"])("button",{class:"link",onClick:t[7]||(t[7]=function(t){return e.startQuiz()}),disabled:(!e.selectedObra.obraId||!e.selectedListaVerificacion.listaVerificacionId)&&!e.$route.params.id||e.blockRealizarPrueba}," Realizar prueba ",8,["disabled"]),e.pruebas.listaRecords.length>0?(Object(n["p"])(),Object(n["d"])("button",{key:0,class:"action-button massive",onClick:t[8]||(t[8]=function(t){return e.deleteMassive()})}," Eliminación masiva ")):Object(n["e"])("",!0),Object(n["g"])(f,{dataSource:e.pruebas,columns:e.columns,config:e.config,actions:e.actions,rows:e.rows,rowHeaderStyle:"thin",rowBodyStyle:"thin",onMovePage:t[9]||(t[9]=function(){}),onSelectedList:e.selectedList},null,8,["dataSource","columns","config","actions","rows","onSelectedList"])])]),J])])],64)})),Q=a("5530"),Y=a("1da1"),X=(a("96cf"),a("d3b7"),a("3ca3"),a("ddb0"),a("d81d"),a("7db0"),a("99af"),a("a9e3"),a("159b"),a("25f0"),a("f464")),W=a("9fbc"),Z=a("d43e"),ee=a("5c40"),te=a("2fc2"),ae=a("3e2f"),ne=a("f50d"),ie=a("b7ff"),ce=a("705f"),oe=Object(ee["l"])({components:{NavBar:X["a"],Grid:W["a"],ConfirmationModal:ie["a"],Modal:ce["a"]},computed:{verifyPruebaCompleta:function(){return this.pruebas.listaRecords.some((function(e){return e.estado="Completa"}))},selectedListaVerificacion:function(){return this.$store.getters["listaVerificacionModule/selectedListaVerificacion"]},selectedObra:function(){return this.$store.getters["obraModule/selectedObra"]},evaluacion:function(){return this.$store.getters["evaluacionModule/obtenerEvaluacion"]}},data:function(){return{userInfoJson:Object(Z["h"])(),pruebas:ae["d"],columns:te["h"],config:{deleteEntity:"",entity:te["l"].PRUEBA},actions:[{icon:"fas fa-trash-alt",type:te["e"].DELETE,method:this.delete},{icon:"fas fa-eye",type:te["e"].EDIT,method:this.edit}],rows:1,codigoListaVerificacion:"",codigoObra:"",obras:[],listasVerificacion:[],timeout:void 0,id:"",modalTitle:"",showModalConfirmation:!1,entityList:[],massiveDelete:!1,message:null,loading:!1,error:!1,blockRealizarPrueba:!1}},methods:{delete:function(e){this.id=e,this.modalTitle="Está seguro que desea eliminar la prueba "+e+"?",this.showModalConfirmation=!0},confirmMassiveDelete:function(){var e=this;return Object(Y["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:Promise.all(e.entityList.map(function(){var t=Object(Y["a"])(regeneratorRuntime.mark((function t(a){var n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:if(n=e.pruebas.listaRecords.find((function(e){return e.id==+a})),!n){t.next=11;break}return t.prev=2,t.next=5,fetch("".concat(te["c"],"prueba/").concat(n.pruebaId),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 5:t.sent,t.next=11;break;case 8:t.prev=8,t.t0=t["catch"](2),console.log(t.t0);case 11:case"end":return t.stop()}}),t,null,[[2,8]])})));return function(e){return t.apply(this,arguments)}}())),e.massiveDelete=!1,e.showModalConfirmation=!1,e.modalTitle="",e.message="Los pruebas fueron eliminadas",setTimeout(Object(Y["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.fetchEvaluacion();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3);case 6:case"end":return t.stop()}}),t)})))()},edit:function(e){var t=this.pruebas.listaRecords.find((function(t){return t.id==Number(e)}));"Pendiente"==(null===t||void 0===t?void 0:t.estado)?this.$router.push("/evaluacion/".concat(this.evaluacion.codigo,"/prueba/").concat(t.codigo)):this.$router.push("/lista-verificacion/".concat(this.selectedListaVerificacion.codigo,"/prueba/").concat(null===t||void 0===t?void 0:t.codigo,"/resumen"))},selectedList:function(e){this.entityList=e},handleError:function(){this.message=null},closeModal:function(){this.showModalConfirmation=!1},deleteMassive:function(){this.entityList.length>0?(this.massiveDelete=!0,this.showModalConfirmation=!0,this.modalTitle="Está seguro que desea eliminar las pruebass seleccionadas ?"):(this.message="Debe seleccionar al menos una prueba",this.error=!0)},confirmDelete:function(){var e=this;return Object(Y["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return e.closeModal(),a=e.pruebas.listaRecords.find((function(t){return t.id==Number(e.id)})),t.prev=2,t.next=5,fetch("".concat(te["c"],"prueba/").concat(null===a||void 0===a?void 0:a.pruebaId),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 5:t.sent,e.message="La prueba fue eliminada",e.id="",setTimeout(Object(Y["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.fetchEvaluacion();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3),t.next=14;break;case 11:t.prev=11,t.t0=t["catch"](2),console.log(t.t0);case 14:case"end":return t.stop()}}),t,null,[[2,11]])})))()},searchObra:function(){var e=this;clearTimeout(this.timeout),this.timeout=setTimeout(Object(Y["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(te["c"],"obras/lista?filter=").concat(e.codigoObra),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return a=t.sent,t.next=6,a.json();case 6:e.obras=t.sent,t.next=12;break;case 9:t.prev=9,t.t0=t["catch"](0),console.log(t.t0);case 12:case"end":return t.stop()}}),t,null,[[0,9]])}))),1e3)},fetchListListaVerificacion:function(){var e=this;return Object(Y["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(te["c"],"listaverificaciones/lista?filter=").concat(e.codigoListaVerificacion),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return a=t.sent,t.next=6,a.json();case 6:e.listasVerificacion=t.sent,t.next=12;break;case 9:t.prev=9,t.t0=t["catch"](0),console.log(t.t0);case 12:case"end":return t.stop()}}),t,null,[[0,9]])})))()},searchListaVerificacion:function(){var e=this;clearTimeout(this.timeout),this.timeout=setTimeout(Object(Y["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.fetchListListaVerificacion();case 2:case"end":return t.stop()}}),t)}))),1e3)},SelectObra:function(e){this.$store.dispatch("obraModule/guardarObra",Object(Q["a"])({},e)),this.obras=[],this.codigoObra=e.codigo+"-"+e.nombre},selectListaVerificacion:function(e){this.$store.dispatch("listaVerificacionModule/guardarListaVerificacion",Object(Q["a"])({},e)),this.listasVerificacion=[],this.codigoListaVerificacion=e.codigo+"-"+e.nombre},startQuiz:function(){var e=this;return Object(Y["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return a={EvaluacionCodigo:e.evaluacion.codigo,EstadoEvaluacion:e.evaluacion.estado,EvaluacionNombre:e.evaluacion.nombre,ObraId:e.selectedObra.obraId,ListaVerificacionId:e.selectedListaVerificacion.listaVerificacionId},t.prev=1,t.next=4,fetch("".concat(te["c"],"evaluacion"),{method:"POST",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")}),body:JSON.stringify(a)});case 4:t.next=9;break;case 6:t.prev=6,t.t0=t["catch"](1),console.log(t.t0);case 9:e.$router.push("/evaluacion/".concat(e.evaluacion.codigo,"/prueba/nuevo"));case 10:case"end":return t.stop()}}),t,null,[[1,6]])})))()},preloadFormValues:function(){this.selectedListaVerificacion.fechaCreacion&&(this.codigoListaVerificacion=this.selectedListaVerificacion.codigo+"-"+this.selectedListaVerificacion.nombre),this.selectedObra.codigo&&(this.codigoObra=this.selectedObra.codigo+"-"+this.selectedObra.nombre)},submit:function(){var e=this;this.evaluacion.visibilidad?Object(Y["a"])(regeneratorRuntime.mark((function t(){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return a={nombre:e.evaluacion.nombre},t.prev=1,t.next=4,fetch("".concat(te["c"],"evaluacion/").concat(e.evaluacion.evaluacionId),{method:"PUT",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")}),body:JSON.stringify(a)});case 4:t.next=9;break;case 6:t.prev=6,t.t0=t["catch"](1),console.log(t.t0);case 9:e.$router.push("/dashboard");case 10:case"end":return t.stop()}}),t,null,[[1,6]])})))():Object(Y["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(te["c"],"evaluacion/activar/").concat(e.evaluacion.evaluacionId),{method:"PUT",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:t.next=8;break;case 5:t.prev=5,t.t0=t["catch"](0),console.log(t.t0);case 8:e.$router.push("/dashboard");case 9:case"end":return t.stop()}}),t,null,[[0,5]])})))()},fetchEvaluacion:function(){var e=this;return Object(Y["a"])(regeneratorRuntime.mark((function t(){var a,n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(te["c"],"evaluacion/").concat(e.$route.params.id),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return a=t.sent,t.next=6,a.json();case 6:n=t.sent,e.codigoListaVerificacion=n.codigoConcatenadoListaVerificacion,e.codigoObra=n.codigoConcatenadoObra,e.pruebas.numeroPaginas=1,e.pruebas.totalRecords=1,e.selectedListaVerificacion.fechaCreacion=n.listaVerificacionFechaCreacion,e.selectedListaVerificacion.requerimientosCount=n.requerimientosCount,e.selectedListaVerificacion.codigo=n.codigoListaVerificacion,e.selectedListaVerificacion.listaVerificacionId=n.listaVerificacionId,e.selectedObra.obraId=n.obraId,e.pruebas.listaRecords=[],n.pruebaList.forEach((function(t,a){e.pruebas.listaRecords.push({id:a+1,fechaCreacion:new Date(t.fechaCreacion).toLocaleDateString(),estado:t.visibilidad?"Completa":"Pendiente",pruebaId:t.pruebaId,codigo:t.codigo})})),e.blockRealizarPrueba=e.pruebas.listaRecords.some((function(e){return"Pendiente"==e.estado})),e.rows=e.pruebas.listaRecords.length,e.$store.dispatch("evaluacionModule/guardarEvaluacion",Object(Q["a"])(Object(Q["a"])({},e.evaluacion),{},{evaluacionId:n.evaluacionId,codigo:n.codigo,nombre:n.nombre,estado:n.estado,visibilidad:n.visibilidad,fechaCreacion:new Date(n.fechaCreacion).toLocaleDateString()})),t.next=26;break;case 23:t.prev=23,t.t0=t["catch"](0),console.log(t.t0);case 26:case"end":return t.stop()}}),t,null,[[0,23]])})))()}},mounted:function(){var e=this;Object(Y["a"])(regeneratorRuntime.mark((function t(){var a,n,i;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,Object(ne["a"])();case 2:if(e.userInfoJson=t.sent,e.$route.params.id){t.next=21;break}return t.prev=4,t.next=7,fetch("".concat(te["c"],"evaluacion/count"),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 7:return a=t.sent,t.next=10,a.json();case 10:n=t.sent,i="",i=n>99?"":n>10?"0":"00",e.$store.dispatch("evaluacionModule/guardarEvaluacion",Object(Q["a"])(Object(Q["a"])({},e.evaluacion),{},{codigo:"EV"+i+(n+1).toString(),fechaCreacion:(new Date).toLocaleDateString()})),t.next=19;break;case 16:t.prev=16,t.t0=t["catch"](4),console.log(t.t0);case 19:t.next=23;break;case 21:return t.next=23,e.fetchEvaluacion();case 23:case"end":return t.stop()}}),t,null,[[4,16]])})))()}});a("0609");oe.render=K,oe.__scopeId="data-v-264760ea";t["default"]=oe},"3e2f":function(e,t,a){"use strict";a.d(t,"k",(function(){return n})),a.d(t,"n",(function(){return i})),a.d(t,"h",(function(){return c})),a.d(t,"f",(function(){return o})),a.d(t,"i",(function(){return r})),a.d(t,"g",(function(){return s})),a.d(t,"e",(function(){return l})),a.d(t,"m",(function(){return u})),a.d(t,"j",(function(){return d})),a.d(t,"l",(function(){return b})),a.d(t,"o",(function(){return f})),a.d(t,"d",(function(){return p})),a.d(t,"c",(function(){return g})),a.d(t,"a",(function(){return h})),a.d(t,"b",(function(){return m}));var n=[{name:"PRODUCT A",data:[44,55,41,67,22,43]},{name:"PRODUCT B",data:[13,23,20,8,13,27]},{name:"PRODUCT C",data:[11,17,15,15,21,14]},{name:"PRODUCT D",data:[21,7,25,13,22,8]}],i=["01/01/2011 GMT","01/02/2011 GMT","01/03/2011 GMT","01/04/2011 GMT","01/05/2011 GMT","01/06/2011 GMT"],c=[44,55,13,43,22],o=["Team A","Team B","Team C","Team D","Team E"],r=[44,55,13,43,22],s=["Team A","Team B","Team C","Team D","Team E"],l=[{name:"High - 2013",data:[12,29,33,36,32,32,33]},{name:"Low - 2013",data:[28,11,14,18,17,13,13]}],u=[{data:[{x:"New Delhi",y:218},{x:"Kolkata",y:149},{x:"Mumbai",y:184},{x:"Ahmedabad",y:55},{x:"Bangaluru",y:84},{x:"Pune",y:31},{x:"Chennai",y:70},{x:"Jaipur",y:30},{x:"Surat",y:44},{x:"Hyderabad",y:68},{x:"Lucknow",y:28},{x:"Indore",y:19},{x:"Kanpur",y:29}]}],d=[62.99,37.01],b=[{name:"Marine Sprite",data:[44,55,41,37,22,43,21]},{name:"Striking Calf",data:[53,32,33,52,13,43,32]},{name:"Tank Picture",data:[12,17,11,9,15,11,20]},{name:"Bucket Slope",data:[9,7,5,8,6,9,4]},{name:"Reborn Kid",data:[25,12,19,32,25,24,10]}],f=[2008,2009,2010,2011,2012,2013,2014],p={listaRecords:[],numeroPaginas:1,totalRecords:0},g=[{codigo:"TR001",fechaInicio:"05/06/2021",fechaFin:"11/06/2021",estado:"Solucionado",evaluacion:"EV001-Departamento Bohem",responsable:"Luis Quispe"},{codigo:"TR002",fechaInicio:"01/01/2021",fechaFin:"07/01/2021",estado:"Asignado",evaluacion:"EV002-Departamento Plaza 27",responsable:"Marcelo Lopez"}],h=[{codigo:"EV001",obra:"OB001-Departamento Bohem",nivelRiesgo:"Bajo",porcentajeCumplimiento:"30%",duracion:"12"},{codigo:"EV002",obra:"OB002-Departamento Plaza 27",nivelRiesgo:"Medio",porcentajeCumplimiento:"60%",duracion:"24"}],m=[{normativa:"29783",codigoEvaluacion:"EV001",evaluacion:"Evaluacion de elementos de seguridad",nivelRiesgo:"Medio",fechaCreacion:"15/05/2021"},{normativa:"ISO 45001",codigoEvaluacion:"EV002",evaluacion:"Evaluacion de elementos peligrosos",nivelRiesgo:"Bajo",fechaCreacion:"25/05/2021"}]},4813:function(e,t,a){"use strict";a("0a17")},5899:function(e,t){e.exports="\t\n\v\f\r                　\u2028\u2029\ufeff"},"58a8":function(e,t,a){var n=a("1d80"),i=a("5899"),c="["+i+"]",o=RegExp("^"+c+c+"*"),r=RegExp(c+c+"*$"),s=function(e){return function(t){var a=String(n(t));return 1&e&&(a=a.replace(o,"")),2&e&&(a=a.replace(r,"")),a}};e.exports={start:s(1),end:s(2),trim:s(3)}},"5ef3":function(e,t,a){},"682b":function(e,t,a){"use strict";function n(e){var t=new Date(e),a=Date.now()-t.getTime(),n=new Date(a);return Math.abs(n.getUTCFullYear()-1970)}a.d(t,"a",(function(){return n}))},7156:function(e,t,a){var n=a("861d"),i=a("d2bb");e.exports=function(e,t,a){var c,o;return i&&"function"==typeof(c=t.constructor)&&c!==a&&n(o=c.prototype)&&o!==a.prototype&&i(e,o),e}},"7db0":function(e,t,a){"use strict";var n=a("23e7"),i=a("b727").find,c=a("44d2"),o="find",r=!0;o in[]&&Array(1)[o]((function(){r=!1})),n({target:"Array",proto:!0,forced:r},{find:function(e){return i(this,e,arguments.length>1?arguments[1]:void 0)}}),c(o)},"9d17":function(e,t,a){},"9fbc":function(e,t,a){"use strict";var n=a("7a23"),i=Object(n["J"])("data-v-072572d4");Object(n["s"])("data-v-072572d4");var c={class:"grid"},o={key:0},r={key:1},s={key:0},l=Object(n["g"])("br",null,null,-1),u={key:0},d={key:1,class:"no-data"},b={key:0},f={key:1},p={key:0};Object(n["q"])();var g=i((function(e,t,a,i,g,h){var m,v,O;return Object(n["p"])(),Object(n["d"])(n["a"],null,[Object(n["g"])("table",c,[Object(n["g"])("thead",{class:e.rowHeaderStyle?"".concat(e.rowHeaderStyle," header-grid"):"header-grid"},[Object(n["g"])("tr",null,[(null===(m=e.actions)||void 0===m?void 0:m.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(n["p"])(),Object(n["d"])("th",o,[Object(n["H"])(Object(n["g"])("input",{type:"checkbox",id:"checkbox","onUpdate:modelValue":t[1]||(t[1]=function(t){return e.massiveCheck=t})},null,512),[[n["B"],e.massiveCheck]])])):Object(n["e"])("",!0),(Object(n["p"])(!0),Object(n["d"])(n["a"],null,Object(n["v"])(e.columns,(function(e){return Object(n["p"])(),Object(n["d"])("th",{key:e.field,style:{textAlign:e.align?e.align:"left"}},Object(n["z"])(e.title),5)})),128)),(null===(v=e.actions)||void 0===v?void 0:v.length)>0?(Object(n["p"])(),Object(n["d"])("th",r,"Acciones")):Object(n["e"])("",!0)])],2),e.dataSource.listaRecords&&0===(null===(O=e.dataSource.listaRecords)||void 0===O?void 0:O.length)?(Object(n["p"])(),Object(n["d"])("div",s,[l,e.rowBodyStyle?(Object(n["p"])(),Object(n["d"])("p",d,"Sin registros")):(Object(n["p"])(),Object(n["d"])("h3",u,"No hay datos registrados"))])):Object(n["e"])("",!0),Object(n["g"])("tbody",{class:e.rowBodyStyle?e.rowBodyStyle:""},[(Object(n["p"])(!0),Object(n["d"])(n["a"],null,Object(n["v"])(e.rows,(function(a,i){var c,o;return Object(n["p"])(),Object(n["d"])("tr",{key:a},[(null===(c=e.actions)||void 0===c?void 0:c.length)>0&&"delete"==e.actions[0].type&&e.dataSource.listaRecords.length>0?(Object(n["p"])(),Object(n["d"])("td",b,[e.dataSource.listaRecords&&e.dataSource.listaRecords[i]?Object(n["H"])((Object(n["p"])(),Object(n["d"])("input",{key:0,type:"checkbox",id:e.dataSource.listaRecords[i].id,value:e.dataSource.listaRecords[i].id,"onUpdate:modelValue":t[2]||(t[2]=function(t){return e.checkedEntities=t})},null,8,["id","value"])),[[n["B"],e.checkedEntities]]):Object(n["e"])("",!0)])):Object(n["e"])("",!0),(Object(n["p"])(!0),Object(n["d"])(n["a"],null,Object(n["v"])(e.columns,(function(t){return Object(n["p"])(),Object(n["d"])("td",{key:t.field},[Object(n["g"])("p",{style:{textAlign:t.align?t.align:"left"}},Object(n["z"])(e.getValue(t.field,e.dataSource.listaRecords,a-1)),5)])})),128)),(null===(o=e.actions)||void 0===o?void 0:o.length)>0?(Object(n["p"])(),Object(n["d"])("td",f,[(Object(n["p"])(!0),Object(n["d"])(n["a"],null,Object(n["v"])(e.actions,(function(t){return Object(n["p"])(),Object(n["d"])("span",{key:t.type},[e.dataSource.listaRecords[i]?(Object(n["p"])(),Object(n["d"])("i",{key:0,class:t.icon,style:{"margin-left":"18px"},onClick:function(a){return t.method(e.dataSource.listaRecords[i].id,e.dataSource.listaRecords[i].entity)}},null,10,["onClick"])):Object(n["e"])("",!0)])})),128))])):Object(n["e"])("",!0)])})),128))],2)]),e.dataSource.numeroPaginas>1?(Object(n["p"])(),Object(n["d"])("div",p,[(Object(n["p"])(!0),Object(n["d"])(n["a"],null,Object(n["v"])(e.dataSource.numeroPaginas,(function(t){return Object(n["p"])(),Object(n["d"])("div",{key:t,class:"pageButton",onClick:function(a){return e.goPage(t)}},Object(n["z"])(t),9,["onClick"])})),128))])):Object(n["e"])("",!0)],64)})),h=(a("a9e3"),a("d81d"),a("682b")),m=a("5c40");function v(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}var O=function e(t,a,n){v(this,e),this.listaRecords=t,this.numeroPaginas=a,this.totalRecords=n},j=Object(m["l"])({props:{columns:{type:Array,required:!0},dataSource:{type:O,required:!0},config:{type:null,required:!1},actions:{type:null,required:!1,default:[]},method:{type:Function,required:!1},rows:{type:Number,required:!1,default:5},pages:{type:Number,required:!0},rowHeaderStyle:{type:String,required:!1},rowBodyStyle:{type:String,required:!1}},emits:["selectedList","movePage"],data:function(){return{massiveCheck:!1,checkedEntities:[]}},watch:{massiveCheck:function(){this.massiveCheck?this.checkedEntities=this.dataSource.listaRecords.map((function(e){return e.id})):this.checkedEntities=[]},checkedEntities:function(){this.$emit("selectedList",this.checkedEntities)}},methods:{goPage:function(e){this.$emit("movePage",e)},getValue:function(e,t,a){if(t)return t[a]?"fechaNacimiento"===e?Object(h["a"])(t[a][e]):t[a][e]:""}}});a("4813");j.render=g,j.__scopeId="data-v-072572d4";t["a"]=j},a9e3:function(e,t,a){"use strict";var n=a("83ab"),i=a("da84"),c=a("94ca"),o=a("6eeb"),r=a("5135"),s=a("c6b6"),l=a("7156"),u=a("c04e"),d=a("d039"),b=a("7c73"),f=a("241c").f,p=a("06cf").f,g=a("9bf2").f,h=a("58a8").trim,m="Number",v=i[m],O=v.prototype,j=s(b(O))==m,y=function(e){var t,a,n,i,c,o,r,s,l=u(e,!1);if("string"==typeof l&&l.length>2)if(l=h(l),t=l.charCodeAt(0),43===t||45===t){if(a=l.charCodeAt(2),88===a||120===a)return NaN}else if(48===t){switch(l.charCodeAt(1)){case 66:case 98:n=2,i=49;break;case 79:case 111:n=8,i=55;break;default:return+l}for(c=l.slice(2),o=c.length,r=0;r<o;r++)if(s=c.charCodeAt(r),s<48||s>i)return NaN;return parseInt(c,n)}return+l};if(c(m,!v(" 0o1")||!v("0b1")||v("+0x1"))){for(var w,k=function(e){var t=arguments.length<1?0:e,a=this;return a instanceof k&&(j?d((function(){O.valueOf.call(a)})):s(a)!=m)?l(new v(y(t)),a,k):y(t)},C=n?f(v):"MAX_VALUE,MIN_VALUE,NaN,NEGATIVE_INFINITY,POSITIVE_INFINITY,EPSILON,isFinite,isInteger,isNaN,isSafeInteger,MAX_SAFE_INTEGER,MIN_SAFE_INTEGER,parseFloat,parseInt,isInteger,fromString,range".split(","),x=0;C.length>x;x++)r(v,w=C[x])&&!r(k,w)&&g(k,w,p(v,w));k.prototype=O,O.constructor=k,o(i,m,k)}},aa14:function(e,t,a){"use strict";a("5ef3")},ad6d:function(e,t,a){"use strict";var n=a("825a");e.exports=function(){var e=n(this),t="";return e.global&&(t+="g"),e.ignoreCase&&(t+="i"),e.multiline&&(t+="m"),e.dotAll&&(t+="s"),e.unicode&&(t+="u"),e.sticky&&(t+="y"),t}},b7ff:function(e,t,a){"use strict";var n=a("7a23"),i=Object(n["J"])("data-v-ea440b04");Object(n["s"])("data-v-ea440b04");var c={key:0,class:"modal"},o=Object(n["g"])("i",{class:"far fa-times-circle fa-2x"},null,-1),r={class:"flex-button"};Object(n["q"])();var s=i((function(e,t,a,i,s,l){var u=Object(n["x"])("backdrop");return Object(n["p"])(),Object(n["d"])(n["a"],null,[Object(n["g"])(u,{show:e.show,onClose:e.tryClose,closable:!1},null,8,["show","onClose"]),e.show?(Object(n["p"])(),Object(n["d"])("div",c,[o,Object(n["g"])("p",null,Object(n["z"])(e.title),1),Object(n["g"])("div",r,[Object(n["g"])("button",{onClick:t[1]||(t[1]=function(t){return e.confirm()}),class:"action-button"},"Aceptar"),Object(n["g"])("button",{style:{background:"var(--danger)"},onClick:t[2]||(t[2]=function(t){return e.cancel()}),class:"action-button"}," Cancelar ")])])):Object(n["e"])("",!0)],64)})),l=a("5c40"),u=a("c2de"),d=Object(l["l"])({components:{Backdrop:u["a"]},props:{show:{type:Boolean,required:!0},title:{type:String,required:!1},fixed:{type:Boolean,required:!1,default:!1},error:{type:Boolean,required:!0},loading:{type:Boolean,required:!0},massiveDelete:{type:Boolean,required:!1}},emits:["confirmMassive","close","confirm","cancel"],methods:{tryClose:function(){this.$emit("close")},confirm:function(){this.massiveDelete?this.$emit("confirmMassive"):this.$emit("confirm")},cancel:function(){this.$emit("cancel")}}});a("aa14");d.render=s,d.__scopeId="data-v-ea440b04";t["a"]=d},cefe:function(e,t,a){"use strict";a("0aec")},d81d:function(e,t,a){"use strict";var n=a("23e7"),i=a("b727").map,c=a("1dde"),o=c("map");n({target:"Array",proto:!0,forced:!o},{map:function(e){return i(this,e,arguments.length>1?arguments[1]:void 0)}})},f464:function(e,t,a){"use strict";a("b0c0");var n=a("7a23"),i=Object(n["J"])("data-v-5a41f577");Object(n["s"])("data-v-5a41f577");var c={class:"header"};Object(n["q"])();var o=i((function(e,t,a,i,o,r){return Object(n["p"])(),Object(n["d"])("div",c,[Object(n["g"])("p",{onClick:t[1]||(t[1]=function(t){return e.goToDashboard()}),class:"dashboardText"},"Sistema Experto de Monitoreo"),Object(n["g"])("p",null,"Bienvenido: "+Object(n["z"])(e.name+" "+e.lastName),1)])})),r=a("5c40"),s=Object(r["l"])({props:["name","lastName"],methods:{goToDashboard:function(){this.$router.push("/dashboard")}}});a("cefe");s.render=o,s.__scopeId="data-v-5a41f577";t["a"]=s},f50d:function(e,t,a){"use strict";a.d(t,"a",(function(){return c}));var n=a("1da1"),i=(a("96cf"),a("d3b7"),a("2fc2"));function c(){return o.apply(this,arguments)}function o(){return o=Object(n["a"])(regeneratorRuntime.mark((function e(){var t,a;return regeneratorRuntime.wrap((function(e){while(1)switch(e.prev=e.next){case 0:return e.next=2,fetch("".concat(i["c"],"usuario"),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 2:return t=e.sent,e.next=5,t.json();case 5:return a=e.sent,e.abrupt("return",a);case 7:case"end":return e.stop()}}),e)}))),o.apply(this,arguments)}}}]);
//# sourceMappingURL=chunk-3f22480c.120f5be2.js.map