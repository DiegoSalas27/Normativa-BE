(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["chunk-fdcd047a"],{3391:function(e,t,n){"use strict";n("7e19")},"7e19":function(e,t,n){},d2a7:function(e,t,n){"use strict";n.r(t);n("b680");var a=n("7a23"),c=n("1d35"),o=n.n(c),i=n("c3e0"),r=n.n(i),s=n("ba97"),u=n.n(s),l=Object(a["J"])("data-v-24bb2ea7");Object(a["s"])("data-v-24bb2ea7");var d={id:"main"},b={class:"grid-container"},p={class:"grid-item"},g=Object(a["g"])("h4",null,"Código de tratamiento:",-1),m=Object(a["g"])("img",{src:o.a,alt:"codeva",class:"imgIcon"},null,-1),h={key:0},j={class:"grid-item"},O=Object(a["g"])("h4",null,"Código de evaluación:",-1),f=Object(a["g"])("img",{src:o.a,alt:"codeva",class:"imgIcon"},null,-1),v={key:0},k={style:{position:"absolute"}},w={key:2,class:"error"},x={class:"grid-item"},y=Object(a["g"])("h4",null,"Código de prueba:",-1),E=Object(a["g"])("img",{src:o.a,alt:"codeva",class:"imgIcon"},null,-1),I={key:0},C={class:"grid-item"},T=Object(a["g"])("h4",null,"Nombre del plan de tratamiento:",-1),M=Object(a["g"])("img",{src:r.a,alt:"codeva",class:"imgIcon"},null,-1),A={key:0},J={key:2,class:"error"},R={class:"grid-item"},S=Object(a["g"])("h4",null,"Responsable:",-1),_=Object(a["g"])("img",{src:u.a,alt:"codeva",class:"imgIcon"},null,-1),$={key:0},z={class:"grid-item",style:{"margin-top":"50px"}},D={key:1,id:"acciones-mitigacion"},F=Object(a["g"])("h4",null,"Acciones de mitigación",-1),L=Object(a["g"])("br",null,null,-1),H={key:0,class:"flex-row table-options"},B=Object(a["f"])("   "),P={class:"grid"},G={class:"header-grid"},V={key:0},U=Object(a["g"])("th",{style:{width:"60%"}},"Acciones de mitigación",-1),N=Object(a["g"])("th",{style:{width:"12.5%"}},"Fecha de inicio",-1),q=Object(a["g"])("th",{style:{width:"12.5%"}},"Fecha de fin",-1),K={key:1},Q={key:2},W=Object(a["g"])("th",{style:{width:"15%"}},"Estado",-1),X={key:0},Y={style:{width:"60%","text-align":"left"}},Z={key:0,style:{width:"90%"}},ee={key:2,class:"far fa-envelope"},te={style:{width:"12.5%"}},ne={key:0},ae={style:{width:"12.5%"}},ce={key:0},oe=Object(a["g"])("i",{class:"fas fa-edit"},null,-1),ie=Object(a["g"])("i",{class:"fas fa-trash-alt",style:{color:"red"}},null,-1),re={style:{width:"15%"}};Object(a["q"])();var se=l((function(e,t,n,c,o,i){var r,s,u,l,se=Object(a["x"])("nav-bar"),ue=Object(a["x"])("confirmation-modal"),le=Object(a["x"])("modal");return Object(a["p"])(),Object(a["d"])(a["a"],null,[Object(a["g"])(se,{name:null===(r=e.userInfoJson)||void 0===r?void 0:r.nombres,lastName:null===(s=e.userInfoJson)||void 0===s?void 0:s.apellidos},null,8,["name","lastName"]),Object(a["g"])(ue,{error:null,show:e.showModalConfirmation,title:e.modalTitle,massiveDelete:e.massiveDelete,onConfirm:e.deleteAccion,onConfirmMassive:e.confirmMassiveDelete,onCancel:e.closeModal},null,8,["show","title","massiveDelete","onConfirm","onConfirmMassive","onCancel"]),Object(a["g"])(le,{show:!!e.message,title:e.message,onClose:e.handleError,error:e.error,loading:e.loading},null,8,["show","title","onClose","error","loading"]),Object(a["g"])("section",d,[Object(a["g"])("h1",null,Object(a["z"])(e.displayTitlePage),1),100!=e.tratamientoInfoJson.porcentajeAvance||e.esAltaGerencia?Object(a["e"])("",!0):(Object(a["p"])(),Object(a["d"])("button",{key:0,class:"action-button",style:{top:"140px"},onClick:t[1]||(t[1]=function(t){return e.register()})}," Generar informe ")),Object(a["g"])("div",b,[Object(a["g"])("div",p,[g,m,e.$route.params.tr_codigo&&!e.canEdit||e.$route.params.tr_codigo&&e.canEdit&&!e.update?(Object(a["p"])(),Object(a["d"])("span",h,Object(a["z"])(e.tratamientoInfoJson.codigo),1)):Object(a["e"])("",!0),!e.update&&e.$route.params.tr_codigo||!e.canEdit?Object(a["e"])("",!0):(Object(a["p"])(),Object(a["d"])("input",{key:1,type:"text",disabled:"true",placeholder:e.tratamientoInfoJson.codigo},null,8,["placeholder"]))]),Object(a["g"])("div",j,[O,f,e.$route.params.tr_codigo&&!e.canEdit||e.$route.params.tr_codigo&&e.canEdit&&!e.update?(Object(a["p"])(),Object(a["d"])("span",v,Object(a["z"])(e.codigoEvaluacion),1)):Object(a["e"])("",!0),!e.update&&e.$route.params.tr_codigo||!e.canEdit?Object(a["e"])("",!0):Object(a["H"])((Object(a["p"])(),Object(a["d"])("input",{key:1,type:"text",placeholder:"Buscar por código",onKeyup:t[2]||(t[2]=function(){return e.searchCodigoEvaluacion&&e.searchCodigoEvaluacion.apply(e,arguments)}),"onUpdate:modelValue":t[3]||(t[3]=function(t){return e.codigoEvaluacion=t})},null,544)),[[a["E"],e.codigoEvaluacion,void 0,{trim:!0}]]),Object(a["g"])("div",k,[(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.evaluacionList,(function(t){return Object(a["p"])(),Object(a["d"])("p",{class:"dropdownSelect",key:t.evaluacionId,onClick:function(n){return e.selectEvaluacion(t)}},Object(a["z"])(t.codigo+"-"+t.nombre),9,["onClick"])})),128))]),e.validationForm.evaluacionId?(Object(a["p"])(),Object(a["d"])("p",w,Object(a["z"])(e.validationForm.evaluacionId),1)):Object(a["e"])("",!0)]),Object(a["g"])("div",x,[y,E,e.$route.params.tr_codigo&&!e.canEdit||e.$route.params.tr_codigo&&e.canEdit&&!e.update?(Object(a["p"])(),Object(a["d"])("span",I,Object(a["z"])(e.codigoPrueba),1)):Object(a["e"])("",!0)]),Object(a["g"])("div",C,[T,M,e.$route.params.tr_codigo&&!e.canEdit||e.$route.params.tr_codigo&&e.canEdit&&!e.update?(Object(a["p"])(),Object(a["d"])("span",A,Object(a["z"])(e.tratamientoInfoJson.nombre),1)):Object(a["e"])("",!0),!e.update&&e.$route.params.tr_codigo||!e.canEdit?Object(a["e"])("",!0):Object(a["H"])((Object(a["p"])(),Object(a["d"])("input",{key:1,type:"text",placeholder:"Plan de tratamiento-nombre","onUpdate:modelValue":t[4]||(t[4]=function(t){return e.tratamientoInfoJson.nombre=t})},null,512)),[[a["E"],e.tratamientoInfoJson.nombre,void 0,{trim:!0}]]),e.validationForm.nombre?(Object(a["p"])(),Object(a["d"])("p",J,Object(a["z"])(e.validationForm.nombre),1)):Object(a["e"])("",!0)]),Object(a["g"])("div",R,[S,_,e.$route.params.tr_codigo&&!e.canEdit||e.$route.params.tr_codigo&&e.canEdit&&!e.update?(Object(a["p"])(),Object(a["d"])("span",$,Object(a["z"])(e.analistaCalc()),1)):Object(a["e"])("",!0),!e.update&&e.$route.params.tr_codigo||!e.canEdit?Object(a["e"])("",!0):Object(a["H"])((Object(a["p"])(),Object(a["d"])("select",{key:1,class:"select","onUpdate:modelValue":t[5]||(t[5]=function(t){return e.tratamientoInfoJson.usuarioId=t}),name:"analista"},[(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.analistaList,(function(e){return Object(a["p"])(),Object(a["d"])("option",{key:e.usuarioId,value:e.usuarioId},Object(a["z"])(e.codigo+"-"+e.nombres+" "+e.apellidos),9,["value"])})),128))],512)),[[a["D"],e.tratamientoInfoJson.usuarioId]])]),Object(a["g"])("div",z,[Object(a["g"])("h4",null,[Object(a["g"])("strong",null,"Porcentaje de avance: "+Object(a["z"])(null===(u=e.tratamientoInfoJson)||void 0===u||null===(l=u.porcentajeAvance)||void 0===l?void 0:l.toFixed(2))+" %",1)])])]),e.showAccionesMitigacion?(Object(a["p"])(),Object(a["d"])("section",D,[F,L,e.update&&e.canEdit?(Object(a["p"])(),Object(a["d"])("div",H,[Object(a["g"])("div",null,[Object(a["g"])("i",{class:"fas fa-plus-circle",onClick:t[6]||(t[6]=function(){return e.goToTestSummary&&e.goToTestSummary.apply(e,arguments)})}),B,Object(a["g"])("span",{style:{"text-decoration":"underline",cursor:"pointer"},onClick:t[7]||(t[7]=function(){return e.goToTestSummary&&e.goToTestSummary.apply(e,arguments)})},"Añadir nueva acción")]),Object(a["g"])("div",null,[Object(a["g"])("button",{class:"action-button table",onClick:t[8]||(t[8]=function(t){return e.deleteMassive()})}," Eliminación massiva ")])])):Object(a["e"])("",!0),Object(a["g"])("table",P,[Object(a["g"])("thead",G,[Object(a["g"])("tr",null,[e.update&&e.accionesMitigacion.length>0&&e.canEdit?(Object(a["p"])(),Object(a["d"])("th",V,[Object(a["H"])(Object(a["g"])("input",{type:"checkbox",id:"checkbox","onUpdate:modelValue":t[9]||(t[9]=function(t){return e.massiveCheck=t})},null,512),[[a["B"],e.massiveCheck]])])):Object(a["e"])("",!0),U,N,q,e.update?(Object(a["p"])(),Object(a["d"])("th",K)):Object(a["e"])("",!0),e.update&&e.canEdit?(Object(a["p"])(),Object(a["d"])("th",Q)):Object(a["e"])("",!0),W])]),Object(a["g"])("tbody",null,[(Object(a["p"])(!0),Object(a["d"])(a["a"],null,Object(a["v"])(e.accionesMitigacion,(function(n){return Object(a["p"])(),Object(a["d"])("tr",{key:n.accionMitigacionId},[e.update&&e.canEdit?(Object(a["p"])(),Object(a["d"])("td",X,[Object(a["H"])(Object(a["g"])("input",{type:"checkbox",id:n.accionMitigacionId,value:n.accionMitigacionId,"onUpdate:modelValue":t[10]||(t[10]=function(t){return e.checkedEntities=t})},null,8,["id","value"]),[[a["B"],e.checkedEntities]])])):Object(a["e"])("",!0),Object(a["g"])("td",Y,[Object(a["g"])("div",null,[e.$route.params.tr_codigo&&!e.canEdit||e.canEdit&&!e.update?(Object(a["p"])(),Object(a["d"])("span",Z,Object(a["z"])(n.descripcion),1)):Object(a["e"])("",!0),e.update&&e.canEdit?Object(a["H"])((Object(a["p"])(),Object(a["d"])("input",{key:1,type:"text",style:{width:"90%","margin-left":"5px"},"onUpdate:modelValue":function(e){return n.descripcion=e}},null,8,["onUpdate:modelValue"])),[[a["E"],n.descripcion]]):Object(a["e"])("",!0),n.tieneMensaje?(Object(a["p"])(),Object(a["d"])("i",ee)):Object(a["e"])("",!0)])]),Object(a["g"])("td",te,[e.$route.params.tr_codigo&&!e.update?(Object(a["p"])(),Object(a["d"])("span",ne,Object(a["z"])(n.fechaInicio?new Date(n.fechaInicio).toISOString().substr(0,10):(new Date).toISOString().substr(0,10)),1)):Object(a["e"])("",!0),e.update?(Object(a["p"])(),Object(a["d"])("input",{key:1,type:"date",onChange:function(e){return n.fechaInicio=e.target.value},value:e.userInfoJson&&n.fechaInicio?new Date(n.fechaInicio).toISOString().substr(0,10):null},null,40,["onChange","value"])):Object(a["e"])("",!0)]),Object(a["g"])("td",ae,[e.$route.params.tr_codigo&&!e.update?(Object(a["p"])(),Object(a["d"])("span",ce,Object(a["z"])(n.fechaFin?new Date(n.fechaFin).toISOString().substr(0,10):(new Date).toISOString().substr(0,10)),1)):Object(a["e"])("",!0),e.update?(Object(a["p"])(),Object(a["d"])("input",{key:1,type:"date",onChange:function(e){return n.fechaFin=e.target.value},value:e.userInfoJson&&n.fechaFin?new Date(n.fechaFin).toISOString().substr(0,10):null},null,40,["onChange","value"])):Object(a["e"])("",!0)]),e.update?(Object(a["p"])(),Object(a["d"])("td",{key:1,onClick:function(t){return e.editAccion(n)}},[oe],8,["onClick"])):Object(a["e"])("",!0),e.update&&e.canEdit?(Object(a["p"])(),Object(a["d"])("td",{key:2,onClick:function(t){return e.deleteConfirm(n)}},[ie],8,["onClick"])):Object(a["e"])("",!0),Object(a["g"])("td",re,[Object(a["g"])("p",{class:n.estado?"label success":"label error"},Object(a["z"])(n.estado?"Terminado":"En Proceso"),3)])])})),128))])])])):Object(a["e"])("",!0)])],64)})),ue=n("5530"),le=n("1da1"),de=(n("d81d"),n("7db0"),n("d3b7"),n("99af"),n("ac1f"),n("5319"),n("b64b"),n("4de4"),n("96cf"),n("705f")),be=n("f50d"),pe=n("d43e"),ge=n("5c40"),me=n("f464"),he=n("b74e"),je=n("2fc2"),Oe=n("b7ff"),fe=Object(ge["l"])({components:{NavBar:me["a"],ConfirmationModal:Oe["a"],Modal:de["a"]},computed:{evaluacion:function(){return this.$store.getters["evaluacionModule/obtenerEvaluacion"]},displayButtonText:function(){return this.$route.params.tr_codigo?this.update?"Guardar":"Editar":"Registrar"},displayTitlePage:function(){return this.$route.params.tr_codigo&&this.update?"Editar plan de tratamiento":"Visualizar plan de tratamiento"}},data:function(){return{userInfoJson:Object(pe["h"])(),codigoEvaluacion:"",codigoPrueba:"",codigoListaVerificacion:"",timeout:void 0,evaluacionList:[],analistaList:[],pruebas:[],showAccionesMitigacion:!1,validationForm:{},tratamientoInfoJson:Object(pe["g"])(),massiveCheck:!1,checkedEntities:[],accionesMitigacion:[],accionSelected:"",esAltaGerencia:!1,message:null,loading:!1,error:!1,update:!1,modalTitle:"",showModalConfirmation:!1,massiveDelete:!1,canEdit:!1}},watch:{codigoPrueba:function(){var e=this;return Object(le["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:if(!e.$route.params.tr_codigo){t.next=3;break}return t.next=3,e.fetchAccionesMitigacion();case 3:case"end":return t.stop()}}),t)})))()},massiveCheck:function(){this.massiveCheck?this.checkedEntities=this.accionesMitigacion.map((function(e){return e.accionMitigacionId})):this.checkedEntities=[]}},methods:{analistaCalc:function(){var e=this,t=this.analistaList.find((function(t){return t.usuarioId==e.tratamientoInfoJson.usuarioId}));return t?t.codigo+"-"+t.nombres+" "+t.apellidos:""},handleError:function(){this.message=null},closeModal:function(){this.showModalConfirmation=!1},searchCodigoEvaluacion:function(){var e=this;clearTimeout(this.timeout),this.timeout=setTimeout(Object(le["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.fetchEvaluacion();case 2:case"end":return t.stop()}}),t)}))),1e3)},fetchEvaluacion:function(){var e=this;return Object(le["a"])(regeneratorRuntime.mark((function t(){var n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(je["c"],"evaluacion/lista?filter=").concat(e.codigoEvaluacion),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,t.next=6,n.json();case 6:e.evaluacionList=t.sent,t.next=12;break;case 9:t.prev=9,t.t0=t["catch"](0),console.log(t.t0);case 12:case"end":return t.stop()}}),t,null,[[0,9]])})))()},fetchAnalista:function(){var e=this;return Object(le["a"])(regeneratorRuntime.mark((function t(){var n;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(je["c"],"usuario/lista/Analistas"),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,t.next=6,n.json();case 6:e.analistaList=t.sent,t.next=12;break;case 9:t.prev=9,t.t0=t["catch"](0),console.log(t.t0);case 12:case"end":return t.stop()}}),t,null,[[0,9]])})))()},selectEvaluacion:function(e){this.tratamientoInfoJson.evaluacionId=e.evaluacionId,this.evaluacionList=[],this.codigoEvaluacion=e.codigo+"-"+e.nombre,this.pruebas=e.pruebaList},deleteConfirm:function(e){this.accionSelected=e.accionMitigacionId,this.modalTitle="Está seguro que desea eliminar la acción de mitigación?",this.showModalConfirmation=!0},deleteMassive:function(){this.checkedEntities.length>0?(this.massiveDelete=!0,this.showModalConfirmation=!0,this.modalTitle="Está seguro que desea eliminar las acciones de mitigación seleccionadas ?"):(this.message="Debe seleccionar al menos una acción de mitigación",this.error=!0)},register:function(){var e=this;return Object(le["a"])(regeneratorRuntime.mark((function t(){var n,a,c,o,i,r,s;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:if(!e.$route.params.tr_codigo||e.update){t.next=3;break}return e.update=!0,t.abrupt("return");case 3:if(e.validationForm={},n=["evaluacionId","nombre"],a=Object(he["b"])(n,e.tratamientoInfoJson),c=Object(he["d"])(a,e.validationForm),console.log(c),console.log(e.tratamientoInfoJson),!c){t.next=49;break}if(e.$route.params.tr_codigo){t.next=33;break}return t.prev=11,t.next=14,fetch("".concat(je["c"],"plantratamiento"),{method:"POST",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")}),body:JSON.stringify(e.tratamientoInfoJson)});case 14:return o=t.sent,t.next=17,Object(he["a"])(o);case 17:return t.next=19,o.json();case 19:i=t.sent,e.$router.replace("/plan-tratamiento2/".concat(i.codigo)),e.showAccionesMitigacion=!0,e.loading=!1,e.error=!1,e.message="¡El plan de tratamiento ha sido registrado exitósamente!",setTimeout(Object(le["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return e.message="",t.next=3,e.fetchTratamiento();case 3:case"end":return t.stop()}}),t)}))),1500),t.next=31;break;case 28:t.prev=28,t.t0=t["catch"](11),console.log(t.t0);case 31:t.next=49;break;case 33:return r=Object(ue["a"])(Object(ue["a"])({},e.tratamientoInfoJson),{},{AccionMitigacionList:e.accionesMitigacion}),t.prev=34,t.next=37,fetch("".concat(je["c"],"plantratamiento/").concat(e.$route.params.tr_codigo),{method:"PUT",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")}),body:JSON.stringify(r)});case 37:return s=t.sent,t.next=40,Object(he["a"])(s);case 40:e.loading=!1,e.error=!1,e.message="¡El plan de tratamiento ha sido actualizado exitósamente!",setTimeout(Object(le["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:e.message="";case 1:case"end":return t.stop()}}),t)}))),1500),t.next=49;break;case 46:t.prev=46,t.t1=t["catch"](34),console.log(t.t1);case 49:case"end":return t.stop()}}),t,null,[[11,28],[34,46]])})))()},goToTestSummary:function(){this.$router.push("/lista-verificacion/".concat(this.codigoListaVerificacion,"/prueba/").concat(this.codigoPrueba,"/resumen"))},fetchTratamiento:function(){var e=this;return Object(le["a"])(regeneratorRuntime.mark((function t(){var n,a,c;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(je["c"],"plantratamiento/").concat(e.$route.params.tr_codigo),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,t.next=6,n.json();case 6:a=t.sent,c=Object.keys(e.tratamientoInfoJson),e.tratamientoInfoJson=Object(he["b"])(c,a),e.codigoEvaluacion=a.codigoEvaluacion,e.pruebas=a.pruebas.filter((function(e){return e.visibilidad})),e.codigoPrueba=e.pruebas[0].codigo,e.codigoListaVerificacion=a.listaVerificacionCodigo,t.next=18;break;case 15:t.prev=15,t.t0=t["catch"](0),console.log(t.t0);case 18:case"end":return t.stop()}}),t,null,[[0,15]])})))()},fetchAccionesMitigacion:function(){var e=this;return Object(le["a"])(regeneratorRuntime.mark((function t(){var n,a,c;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,fetch("".concat(je["c"],"accionmitigacion/").concat(e.tratamientoInfoJson.tratamientoId,"/").concat(e.codigoPrueba),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 3:return n=t.sent,t.next=6,n.json();case 6:e.accionesMitigacion=t.sent,e.accionesMitigacion.length>0?(a=e.accionesMitigacion.length,c=e.accionesMitigacion.filter((function(e){return 1==e.estado})).length,e.tratamientoInfoJson.porcentajeAvance=c/a*100):e.tratamientoInfoJson.porcentajeAvance=0,t.next=13;break;case 10:t.prev=10,t.t0=t["catch"](0),console.log(t.t0);case 13:case"end":return t.stop()}}),t,null,[[0,10]])})))()},editAccion:function(e){var t=this;return Object(le["a"])(regeneratorRuntime.mark((function n(){return regeneratorRuntime.wrap((function(n){while(1)switch(n.prev=n.next){case 0:t.$router.push("/accion-mitigacion/edicion/".concat(e.accionMitigacionId));case 1:case"end":return n.stop()}}),n)})))()},deleteAccion:function(e){var t=this;return Object(le["a"])(regeneratorRuntime.mark((function n(){var a,c;return regeneratorRuntime.wrap((function(n){while(1)switch(n.prev=n.next){case 0:return t.closeModal(),a=e||t.accionSelected,n.prev=2,n.next=5,fetch("".concat(je["c"],"accionmitigacion/").concat(a),{method:"DELETE",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 5:return c=n.sent,n.next=8,Object(he["a"])(c);case 8:e||(t.message="¡Se ha eliminado accion exitósamente!",setTimeout(Object(le["a"])(regeneratorRuntime.mark((function e(){return regeneratorRuntime.wrap((function(e){while(1)switch(e.prev=e.next){case 0:return t.message="",e.next=3,t.fetchAccionesMitigacion();case 3:case"end":return e.stop()}}),e)}))),1500)),n.next=14;break;case 11:n.prev=11,n.t0=n["catch"](2),console.log(n.t0);case 14:case"end":return n.stop()}}),n,null,[[2,11]])})))()},confirmMassiveDelete:function(){var e=this;return Object(le["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:e.checkedEntities.map(function(){var t=Object(le["a"])(regeneratorRuntime.mark((function t(n){var a;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.prev=0,t.next=3,e.deleteAccion(n);case 3:a=t.sent,console.log(a),t.next=10;break;case 7:t.prev=7,t.t0=t["catch"](0),console.log(t.t0);case 10:case"end":return t.stop()}}),t,null,[[0,7]])})));return function(e){return t.apply(this,arguments)}}()),e.massiveDelete=!1,e.showModalConfirmation=!1,e.modalTitle="",e.message="¡Se ha eliminado las acciones de mitigacion exitósamente!",setTimeout(Object(le["a"])(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,e.fetchAccionesMitigacion();case 2:e.message=null;case 3:case"end":return t.stop()}}),t)}))),2e3);case 6:case"end":return t.stop()}}),t)})))()}},mounted:function(){var e=this;Object(le["a"])(regeneratorRuntime.mark((function t(){var n,a,c;return regeneratorRuntime.wrap((function(t){while(1)switch(t.prev=t.next){case 0:return t.next=2,Object(be["a"])();case 2:return e.userInfoJson=t.sent,e.userInfoJson.rol==je["o"].JEFE_DE_RIESGOS?e.canEdit=!0:e.canEdit=!1,e.userInfoJson.rol==je["o"].ALTA_GERENCIA&&(e.esAltaGerencia=!0),t.next=7,e.fetchAnalista();case 7:if(e.$route.params.tr_codigo){t.next=24;break}return t.prev=8,t.next=11,fetch("".concat(je["c"],"plantratamiento/ultimoCodigo"),{method:"GET",headers:new Headers({"Content-Type":"application/json",Authorization:"Bearer "+localStorage.getItem("token")})});case 11:return n=t.sent,t.next=14,n.json();case 14:a=t.sent,c=a.codigo,e.tratamientoInfoJson.codigo=c,t.next=22;break;case 19:t.prev=19,t.t0=t["catch"](8),console.log(t.t0);case 22:t.next=29;break;case 24:return e.showAccionesMitigacion=!0,t.next=27,e.fetchTratamiento();case 27:return t.next=29,e.fetchAccionesMitigacion();case 29:case"end":return t.stop()}}),t,null,[[8,19]])})))()}});n("3391");fe.render=se,fe.__scopeId="data-v-24bb2ea7";t["default"]=fe}}]);
//# sourceMappingURL=chunk-fdcd047a.6a6ecbef.js.map