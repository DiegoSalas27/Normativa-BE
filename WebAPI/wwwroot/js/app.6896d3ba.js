(function(A){function e(e){for(var t,o,r=e[0],c=e[1],u=e[2],g=0,d=[];g<r.length;g++)o=r[g],Object.prototype.hasOwnProperty.call(i,o)&&i[o]&&d.push(i[o][0]),i[o]=0;for(t in c)Object.prototype.hasOwnProperty.call(c,t)&&(A[t]=c[t]);s&&s(e);while(d.length)d.shift()();return a.push.apply(a,u||[]),n()}function n(){for(var A,e=0;e<a.length;e++){for(var n=a[e],t=!0,o=1;o<n.length;o++){var r=n[o];0!==i[r]&&(t=!1)}t&&(a.splice(e--,1),A=c(c.s=n[0]))}return A}var t={},o={app:0},i={app:0},a=[];function r(A){return c.p+"js/"+({about:"about"}[A]||A)+"."+{"chunk-7a110792":"53646c5f",about:"c6813d0d","chunk-399c52ea":"bb479f56","chunk-490d15be":"fc25f774","chunk-5be99596":"ca8149a3","chunk-a3fd425e":"6a82a786","chunk-7da71b21":"5eb5f5d2","chunk-144652ae":"27bbc561","chunk-8422b39c":"14c90691","chunk-d9cda22e":"4bb8f027"}[A]+".js"}function c(e){if(t[e])return t[e].exports;var n=t[e]={i:e,l:!1,exports:{}};return A[e].call(n.exports,n,n.exports,c),n.l=!0,n.exports}c.e=function(A){var e=[],n={about:1,"chunk-399c52ea":1,"chunk-490d15be":1,"chunk-5be99596":1,"chunk-a3fd425e":1,"chunk-7da71b21":1,"chunk-144652ae":1,"chunk-8422b39c":1,"chunk-d9cda22e":1};o[A]?e.push(o[A]):0!==o[A]&&n[A]&&e.push(o[A]=new Promise((function(e,n){for(var t="css/"+({about:"about"}[A]||A)+"."+{"chunk-7a110792":"31d6cfe0",about:"f423a899","chunk-399c52ea":"0c6d1c28","chunk-490d15be":"a7953165","chunk-5be99596":"ec5c80db","chunk-a3fd425e":"3a0a39f9","chunk-7da71b21":"609a0a16","chunk-144652ae":"3d68d379","chunk-8422b39c":"295c5688","chunk-d9cda22e":"7e963c76"}[A]+".css",i=c.p+t,a=document.getElementsByTagName("link"),r=0;r<a.length;r++){var u=a[r],g=u.getAttribute("data-href")||u.getAttribute("href");if("stylesheet"===u.rel&&(g===t||g===i))return e()}var d=document.getElementsByTagName("style");for(r=0;r<d.length;r++){u=d[r],g=u.getAttribute("data-href");if(g===t||g===i)return e()}var s=document.createElement("link");s.rel="stylesheet",s.type="text/css",s.onload=e,s.onerror=function(e){var t=e&&e.target&&e.target.src||i,a=new Error("Loading CSS chunk "+A+" failed.\n("+t+")");a.code="CSS_CHUNK_LOAD_FAILED",a.request=t,delete o[A],s.parentNode.removeChild(s),n(a)},s.href=i;var p=document.getElementsByTagName("head")[0];p.appendChild(s)})).then((function(){o[A]=0})));var t=i[A];if(0!==t)if(t)e.push(t[2]);else{var a=new Promise((function(e,n){t=i[A]=[e,n]}));e.push(t[2]=a);var u,g=document.createElement("script");g.charset="utf-8",g.timeout=120,c.nc&&g.setAttribute("nonce",c.nc),g.src=r(A);var d=new Error;u=function(e){g.onerror=g.onload=null,clearTimeout(s);var n=i[A];if(0!==n){if(n){var t=e&&("load"===e.type?"missing":e.type),o=e&&e.target&&e.target.src;d.message="Loading chunk "+A+" failed.\n("+t+": "+o+")",d.name="ChunkLoadError",d.type=t,d.request=o,n[1](d)}i[A]=void 0}};var s=setTimeout((function(){u({type:"timeout",target:g})}),12e4);g.onerror=g.onload=u,document.head.appendChild(g)}return Promise.all(e)},c.m=A,c.c=t,c.d=function(A,e,n){c.o(A,e)||Object.defineProperty(A,e,{enumerable:!0,get:n})},c.r=function(A){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(A,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(A,"__esModule",{value:!0})},c.t=function(A,e){if(1&e&&(A=c(A)),8&e)return A;if(4&e&&"object"===typeof A&&A&&A.__esModule)return A;var n=Object.create(null);if(c.r(n),Object.defineProperty(n,"default",{enumerable:!0,value:A}),2&e&&"string"!=typeof A)for(var t in A)c.d(n,t,function(e){return A[e]}.bind(null,t));return n},c.n=function(A){var e=A&&A.__esModule?function(){return A["default"]}:function(){return A};return c.d(e,"a",e),e},c.o=function(A,e){return Object.prototype.hasOwnProperty.call(A,e)},c.p="/",c.oe=function(A){throw console.error(A),A};var u=window["webpackJsonp"]=window["webpackJsonp"]||[],g=u.push.bind(u);u.push=e,u=u.slice();for(var d=0;d<u.length;d++)e(u[d]);var s=g;a.push([0,"chunk-vendors"]),n()})({0:function(A,e,n){A.exports=n("cd49")},"0617":function(A,e){A.exports="data:image/png;base64,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"},"0c65":function(A,e,n){A.exports=n.p+"img/Imagen (15).d2ab7b51.png"},"0eeb":function(A,e,n){A.exports=n.p+"img/informes.0c02468f.png"},"1b0b":function(A,e,n){},"1d35":function(A,e,n){A.exports=n.p+"img/llave.cf0bff8e.png"},2233:function(A,e,n){"use strict";n("fd36")},"26ef":function(A,e,n){A.exports=n.p+"img/construccion2.72a05ba3.jpg"},"2f97":function(A,e,n){A.exports=n.p+"img/obra.8b30ae5b.png"},"2fc2":function(A,e,n){"use strict";n.d(e,"i",(function(){return t})),n.d(e,"h",(function(){return o})),n.d(e,"f",(function(){return i})),n.d(e,"e",(function(){return a})),n.d(e,"d",(function(){return r})),n.d(e,"g",(function(){return c})),n.d(e,"a",(function(){return u})),n.d(e,"b",(function(){return g})),n.d(e,"c",(function(){return d}));var t={ADMINISTRADOR:"Profile",ALTA_GERENCIA:"AltaGerencia",PROFILE_ALTA_GERENCIA:"ProfileAltaGerencia",PROFILE_ANALISTA:"ProfileAnalista",ANALISTAS:"Analistas",AUTDITOR:"auditor",PROFILE_JEFE_DE_RIESGOS:"ProfileJefeRiesgos",REALIZAR_PRUEBA:"Evaluacion",REALIZAR_PRUEBA_EVALUACION:"Prueba",VISUALIZAR_INFORME:"TipoInforme"},o={ANALISTA:"Analistas",JEFE_DE_RIESGOS:"Jefe de riesgos",ADMINISTRADOR:"Administrador",ALTA_GERENCIA:"Alta gerencia"},i=[{field:"codigo",title:"Código",type:"text"},{field:"nombre",title:"Nombre",type:"text"},{field:"especialidad",title:"Especialidad",type:"text"},{field:"email",title:"Correo electrónico",type:"text"},{field:"phoneNumber",title:"Número de teléfono",type:"text"},{field:"fechaNacimiento",title:"Edad",type:"text"}],a=[{field:"id",title:"Nª",type:"number",align:"center"},{field:"fechaCreacion",title:"Fecha de creación",type:"text",align:"center"},{field:"estado",title:"Estado",type:"text",align:"center"}],r={DELETE:"delete",EDIT:"edit"},c={USER:"usuario",PRUEBA:"prueba"},u=[{src:n("a53e"),description:"Alta gerencia",url:t.ALTA_GERENCIA},{src:n("c203"),description:"Analistas",url:t.ANALISTAS},{src:n("3c3a"),description:"Auditor",url:t.AUTDITOR},{src:n("30f5"),description:"Jefe de riesgos",url:t.PROFILE_JEFE_DE_RIESGOS}],g=[{src:n("3c3a"),description:"Realizar prueba",url:t.REALIZAR_PRUEBA},{src:n("0eeb"),description:"Visualizar informes",url:t.VISUALIZAR_INFORME}],d="https://sistemaexperto.azurewebsites.net/api/"},"30f5":function(A,e,n){A.exports=n.p+"img/security.b1529fd2.png"},"35f8":function(A,e,n){A.exports=n.p+"img/Imagen (24).9b184f74.png"},"3c3a":function(A,e,n){A.exports=n.p+"img/audit.8a0a5c07.png"},"3dbb":function(A,e,n){A.exports=n.p+"img/adminImg.b46f9984.png"},"402d":function(A,e,n){},"442d":function(A,e,n){"use strict";n("1b0b")},"4c05":function(A,e,n){A.exports=n.p+"img/alta-gerencia.44d35032.jpg"},5231:function(A,e,n){A.exports=n.p+"img/Imagen (23).e268d657.png"},5540:function(A,e,n){A.exports=n.p+"img/Imagen (30).4742e877.png"},"5b89":function(A,e,n){A.exports=n.p+"img/prueba.86de65c0.png"},"5f1f":function(A,e){A.exports="data:image/png;base64,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"},6010:function(A,e,n){A.exports=n.p+"img/iso45001.55fd826f.jpg"},"61cf":function(A,e){A.exports="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAgAAAAIAAQMAAADOtka5AAAAAXNSR0IArs4c6QAAAAZQTFRFAAAAAAAApWe5zwAAAAF0Uk5TAEDm2GYAAACsSURBVHic7cwxCsAwDARB/f/TCgQXboLtuJNmC8GBmIhRjmLR5x8AAAAAAIAyQF4GAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA8J6fAQAAAAAAqA/k1O4GAAAAAAAAAAAAAAAAAAAAAAAAANAbOA0AAAAAAEB9IKd2NwAAAAAAAAAAAAAAAAAAAAAAAACA3sBpAAAAAAAAAAAAAAAAAPoANwEAAAAAACgHPIRKtZPw8wh5AAAAAElFTkSuQmCC"},6470:function(A,e,n){A.exports=n.p+"img/Imagen (21).f9ded597.png"},6889:function(A,e,n){A.exports=n.p+"img/Imagen (17).89dc2f9b.png"},6948:function(A,e){A.exports="data:image/png;base64,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"},"722d":function(A,e,n){A.exports=n.p+"img/check.75968465.png"},7584:function(A,e,n){var t={"./Imagen (15).png":"0c65","./Imagen (17).png":"6889","./Imagen (18).png":"ec28","./Imagen (2).png":"861b","./Imagen (21).png":"6470","./Imagen (23).png":"5231","./Imagen (24).png":"35f8","./Imagen (25).png":"974f","./Imagen (26).png":"af50","./Imagen (27).png":"7793","./Imagen (28).png":"e6c2","./Imagen (30).png":"5540","./Imagen (31).png":"6948","./Imagen (33).png":"da52","./Imagen (34).png":"a39a","./Imagen (8).png":"61cf","./adminImg.png":"3dbb","./alta-gerencia.jpg":"4c05","./alta.png":"a53e","./analistas.png.crdownload":"7872","./analyst.png":"c203","./audit.png":"3c3a","./auditor.png":"0617","./carduser.png":"5f1f","./check.png":"722d","./construccion.png":"f1de","./construccion2.jpg":"26ef","./date.png":"be24","./informes.png":"0eeb","./iso45001.jpg":"6010","./ley29783.jpg":"f949","./listav.png":"c3e0","./llave.png":"1d35","./norma-tecnica.jpg":"ccd5","./normas-seguridad.jpg":"c3d7","./obra.png":"2f97","./prueba.png":"5b89","./quiz.jpg":"7c9b","./security.png":"30f5","./user.png":"ba97"};function o(A){var e=i(A);return n(e)}function i(A){if(!n.o(t,A)){var e=new Error("Cannot find module '"+A+"'");throw e.code="MODULE_NOT_FOUND",e}return t[A]}o.keys=function(){return Object.keys(t)},o.resolve=i,A.exports=o,o.id="7584"},7793:function(A,e,n){A.exports=n.p+"img/Imagen (27).e25b5673.png"},7872:function(A,e){throw new Error("Module parse failed: Unexpected character '�' (1:0)\nYou may need an appropriate loader to handle this file type, currently no loaders are configured to process this file. See https://webpack.js.org/concepts#loaders\n(Source code omitted for this binary file)")},"7c9b":function(A,e,n){A.exports=n.p+"img/quiz.8db8598d.jpg"},"861b":function(A,e){A.exports="data:image/png;base64,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"},"974f":function(A,e,n){A.exports=n.p+"img/Imagen (25).a70b6153.png"},a39a:function(A,e,n){A.exports=n.p+"img/Imagen (34).ae300099.png"},a53e:function(A,e,n){A.exports=n.p+"img/alta.cd62eb94.png"},aede:function(A,e,n){},af50:function(A,e,n){A.exports=n.p+"img/Imagen (26).a65914b0.png"},ba97:function(A,e,n){A.exports=n.p+"img/user.7d715e75.png"},be24:function(A,e){A.exports="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAgAAAAIAAQMAAADOtka5AAAAAXNSR0IArs4c6QAAAAZQTFRFAAAAAAAApWe5zwAAAAF0Uk5TAEDm2GYAAACsSURBVHic7cwxCsAwDARB/f/TCgQXboLtuJNmC8GBmIhRjmLR5x8AAAAAAIAyQF4GAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA8J6fAQAAAAAAqA/k1O4GAAAAAAAAAAAAAAAAAAAAAAAAANAbOA0AAAAAAEB9IKd2NwAAAAAAAAAAAAAAAAAAAAAAAACA3sBpAAAAAAAAAAAAAAAAAPoANwEAAAAAACgHPIRKtZPw8wh5AAAAAElFTkSuQmCC"},c203:function(A,e,n){A.exports=n.p+"img/analyst.1bf26623.png"},c3d7:function(A,e,n){A.exports=n.p+"img/normas-seguridad.5bfd7a7f.jpg"},c3e0:function(A,e,n){A.exports=n.p+"img/listav.835f7235.png"},ccd5:function(A,e,n){A.exports=n.p+"img/norma-tecnica.487f76d9.jpg"},cd49:function(A,e,n){"use strict";n.r(e);n("e260"),n("e6cf"),n("cca6"),n("a79d");var t=n("7a23");function o(A,e){var n=Object(t["x"])("router-view");return Object(t["p"])(),Object(t["d"])(n)}const i={};i.render=o;var a=i,r=(n("d3b7"),n("3ca3"),n("ddb0"),n("6c02")),c=Object(t["J"])("data-v-186eeecc");Object(t["s"])("data-v-186eeecc");var u={class:"main-container"},g={id:"home"},d={class:"content"},s=Object(t["g"])("h1",null,"LOS RIESGOS BAJO CONTROL",-1),p=Object(t["g"])("p",null," SISTEMA EXPERTO PARA LA PREVENCIÓN DE RIESGOS LABORALES EN CONSTRUCCIÓN DE EDIFICACIONES ",-1),l={id:"features"};Object(t["q"])();var f=c((function(A,e,n,o,i,a){var r=Object(t["x"])("horizontal-flex-list"),c=Object(t["x"])("the-footer");return Object(t["p"])(),Object(t["d"])("section",u,[Object(t["g"])("section",g,[Object(t["g"])("div",d,[s,p,Object(t["g"])("button",{onClick:e[1]||(e[1]=function(e){return A.goToLogin()}),class:"action-button"},"DEMO")])]),Object(t["g"])("section",l,[Object(t["g"])(r,{images:A.images,size:"150px",bgcolor:"white",title:"BASADOS EN NORMATIVAS DE SEGURIDAD LABORAL"},null,8,["images"])]),Object(t["g"])(c)])})),m=(n("a4d3"),n("e01a"),Object(t["J"])("data-v-cd0593a8"));Object(t["s"])("data-v-cd0593a8");var b={key:0},I={class:"flex-items"};Object(t["q"])();var h=m((function(A,e,n,o,i,a){return Object(t["p"])(),Object(t["d"])("section",{class:"list",style:{background:n.bgcolor}},[n.title?(Object(t["p"])(),Object(t["d"])("div",b,[Object(t["g"])("h1",null,Object(t["z"])(n.title),1)])):Object(t["e"])("",!0),Object(t["g"])("section",I,[(Object(t["p"])(!0),Object(t["d"])(t["a"],null,Object(t["v"])(n.images,(function(A){return Object(t["p"])(),Object(t["d"])("div",{key:A},[Object(t["g"])("img",{src:a.getImrUrl(A.src),alt:A,style:{width:n.size,height:n.size}},null,12,["src","alt"]),Object(t["g"])("p",null,Object(t["z"])(A.description),1)])})),128))])],4)})),C={props:["images","size","bgcolor","title"],methods:{getImrUrl:function(A){return n("7584")("./"+A)}}};n("442d");C.render=h,C.__scopeId="data-v-cd0593a8";var E=C,v=Object(t["J"])("data-v-ba872b7c");Object(t["s"])("data-v-ba872b7c");var R={id:"footer"},w=Object(t["g"])("p",null,"© Copyright 2021 - Hurtado & Rojas",-1);Object(t["q"])();var k=v((function(A,e){return Object(t["p"])(),Object(t["d"])("footer",R,[w])}));n("cef8");const j={};j.render=k,j.__scopeId="data-v-ba872b7c";var S=j,O=n("5c40"),B=Object(O["l"])({components:{HorizontalFlexList:E,TheFooter:S},data:function(){return{images:[{src:"ley29783.jpg",description:"Ley Nº 29783"},{src:"norma-tecnica.jpg",description:"Normas técnicas G-050"},{src:"iso45001.jpg",description:"ISP 450001:2018"},{src:"normas-seguridad.jpg",description:"Normas de Seguridad e Higiene en obras"}]}},methods:{goToLogin:function(){this.$router.push("/auth")}}});n("2233");B.render=f,B.__scopeId="data-v-186eeecc";var G=B,L=n("2fc2"),Q=[{path:"/",name:"Home",component:G},{path:"/auth",name:"Authentication",component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("about")]).then(n.bind(null,"886d"))}},{path:"/dashboard",name:"Dashboard",props:!0,component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("about")]).then(n.bind(null,"7277"))},children:[{path:"",name:"Main",props:!0,component:function(){return n.e("chunk-d9cda22e").then(n.bind(null,"cd56"))}},{path:"profile/:id?",name:"Profile",props:!0,component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-490d15be")]).then(n.bind(null,"4a39"))}},{path:"alta-gerencia",name:"AltaGerencia",props:!0,component:function(){return Promise.all([n.e("chunk-7da71b21"),n.e("chunk-8422b39c")]).then(n.bind(null,"1568"))}},{path:"analistas",name:"Analistas",props:!0,component:function(){return Promise.all([n.e("chunk-7da71b21"),n.e("chunk-8422b39c")]).then(n.bind(null,"1568"))}},{path:"profile/jefe-de-riesgos/:id?",name:"ProfileJefeRiesgos",props:!0,component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-490d15be")]).then(n.bind(null,"4a39"))}},{path:"profile/alta-gerencia/:id?",name:"ProfileAltaGerencia",props:!0,component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-490d15be")]).then(n.bind(null,"4a39"))}},{path:"profile/analista/:id?",name:"ProfileAnalista",props:!0,component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-490d15be")]).then(n.bind(null,"4a39"))}}]},{path:"/evaluacion/:id?",name:L["i"].REALIZAR_PRUEBA,props:!0,component:function(){return Promise.all([n.e("chunk-7da71b21"),n.e("chunk-144652ae")]).then(n.bind(null,"3ce8"))}},{path:"/evaluacion/:ev_codigo/prueba/nuevo",name:"PruebaNuevo",component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-399c52ea")]).then(n.bind(null,"d097"))}},{path:"/evaluacion/:ev_codigo/prueba/:pr_codigo?",name:"Prueba",component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-399c52ea")]).then(n.bind(null,"d097"))}},{path:"/evaluacion/:ev_codigo/prueba/:pr_codigo/resumen",name:"PruebaResultado",component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-399c52ea")]).then(n.bind(null,"d097"))}},{path:"/plan-tratamiento/:tr_codigo?",name:"PlanTratamiento",component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-a3fd425e")]).then(n.bind(null,"68d2"))}},{path:"/lista-verificacion/:lv_codigo/prueba/:pr_codigo/resumen",name:"PruebaResumen",component:function(){return Promise.all([n.e("chunk-7a110792"),n.e("chunk-5be99596")]).then(n.bind(null,"71ad"))}},{path:"/:notFound(.*)",redirect:"/"}],F=Object(r["a"])({history:Object(r["b"])("/"),routes:Q}),x=F,N=n("5502"),P=n("5530"),H=n("3835");n("4fad");function D(A,e){for(var n=0,t=Object.entries(A);n<t.length;n++){var o=Object(H["a"])(t[n],2),i=o[0];o[1];e[i]&&(A[i]=e[i])}}var U={guardarListaVerificacion:function(A,e){D(A,e)}},y={guardarListaVerificacion:function(A,e){A.commit("guardarListaVerificacion",e)}},M={selectedListaVerificacion:function(A){return A}},V=n("d43e"),Y={namespaced:!0,state:function(){return Object(P["a"])({},Object(V["i"])())},mutations:U,actions:y,getters:M},J={guardarObra:function(A,e){A.commit("guardarObra",e)}},q={selectedObra:function(A){return A}},K={guardarObra:function(A,e){D(A,e)}},Z={namespaced:!0,state:function(){return Object(P["a"])({},Object(V["e"])())},mutations:K,actions:J,getters:q},T={guardarEvaluacion:function(A,e){A.commit("guardarEvaluacion",e)},actulizarGuidEvaluacionModule:function(A,e){A.commit("actulizarGuidEvaluacionModule",e)}},z={obtenerEvaluacion:function(A){return A},obtenerEvaluacionGuid:function(A){return A.evaluacionId},obtenerEvaluacionCodigo:function(A){return A.codigo}},W={guardarEvaluacion:function(A,e){D(A,e)},actulizarGuidEvaluacionModule:function(A,e){A.evaluacionId=e.guid}},X={namespaced:!0,state:function(){return Object(P["a"])({},Object(V["b"])())},mutations:W,actions:T,getters:z},_={guardarPrueba:function(A,e){A.commit("guardarPrueba",e)},actulizarGuidPruebaModule:function(A,e){A.commit("actulizarGuidPruebaModule",e)}},$={obtenerPrueba:function(A){return A},obtenerPruebaGuid:function(A){return A.pruebaId},obtenerPruebaCodigo:function(A){return A.codigo}},AA={guardarPrueba:function(A,e){D(A,e)},actulizarGuidPruebaModule:function(A,e){A.pruebaId=e.guid}},eA={namespaced:!0,state:function(){return Object(P["a"])({},Object(V["f"])())},mutations:AA,actions:_,getters:$},nA=Object(N["a"])({modules:{listaVerificacionModule:Y,obraModule:Z,evaluacionModule:X,pruebaModule:eA},state:function(){return{}},mutations:{},actions:{},getters:{}}),tA=nA;n("aede"),n("402d");Object(t["c"])(a).use(tA).use(x).mount("#app")},cef8:function(A,e,n){"use strict";n("d09e")},d09e:function(A,e,n){},d43e:function(A,e,n){"use strict";n.d(e,"h",(function(){return t})),n.d(e,"g",(function(){return o})),n.d(e,"i",(function(){return i})),n.d(e,"e",(function(){return a})),n.d(e,"a",(function(){return r})),n.d(e,"b",(function(){return c})),n.d(e,"c",(function(){return u})),n.d(e,"d",(function(){return g})),n.d(e,"f",(function(){return d}));var t=function(){return{nombres:"",apellidos:"",nombreCompleto:"",password:"",token:"",email:"",username:"",imagen:"",phoneNumber:"",fechaNacimiento:null,especialidad:"",rol:null}},o=function(){return{tratamientoId:"",evaluacionId:"",usuarioId:"",nombre:"",codigo:"",fechaInicio:null,fechaFin:null,porcentajeAvance:0}},i=function(){return{listaVerificacionId:"",codigo:"",nombre:"",fechaCreacion:"",requerimientosCount:0,requerimientos:[]}},a=function(){return{obraId:"",codigo:"",nombre:"",evaluacionList:void 0}},r=function(){return{listaRecords:[],numeroPaginas:0,totalRecords:0}},c=function(){return{evaluacionId:void 0,obra:void 0,tratamiento:null,listaVerificacion:void 0,codigo:"",nombre:"",porcentajeFinal:0,estado:"pendiente",fechaCreacion:null,pruebaList:null,visibilidad:!1}},u=function(){return{evidenciaId:"",nombre:"",adjunto:""}},g=function(){return{evidenciaId:"",requerimientoId:"",pruebaId:"",justificacion:"",respuestaItem:1,recomendacion:void 0}},d=function(){return{pruebaId:"",codigo:"",evaluacionId:"",porcentajeCumplimiento:0,evaluacion:void 0,evidenciaRequerimientoLink:[]}}},da52:function(A,e,n){A.exports=n.p+"img/Imagen (33).d1ba0ddd.png"},e6c2:function(A,e,n){A.exports=n.p+"img/Imagen (28).dc866641.png"},ec28:function(A,e,n){A.exports=n.p+"img/Imagen (18).5815de65.png"},f1de:function(A,e,n){A.exports=n.p+"img/construccion.d882dada.png"},f949:function(A,e,n){A.exports=n.p+"img/ley29783.61eb0e25.jpg"},fd36:function(A,e,n){}});
//# sourceMappingURL=app.6896d3ba.js.map