﻿!function (t, e) { for (var n in e) t[n] = e[n] }(window, function (t) { var e = {}; function n(r) { if (e[r]) return e[r].exports; var o = e[r] = { i: r, l: !1, exports: {} }; return t[r].call(o.exports, o, o.exports, n), o.l = !0, o.exports } return n.m = t, n.c = e, n.d = function (t, e, r) { n.o(t, e) || Object.defineProperty(t, e, { enumerable: !0, get: r }) }, n.r = function (t) { "undefined" != typeof Symbol && Symbol.toStringTag && Object.defineProperty(t, Symbol.toStringTag, { value: "Module" }), Object.defineProperty(t, "__esModule", { value: !0 }) }, n.t = function (t, e) { if (1 & e && (t = n(t)), 8 & e) return t; if (4 & e && "object" == typeof t && t && t.__esModule) return t; var r = Object.create(null); if (n.r(r), Object.defineProperty(r, "default", { enumerable: !0, value: t }), 2 & e && "string" != typeof t) for (var o in t) n.d(r, o, function (e) { return t[e] }.bind(null, o)); return r }, n.n = function (t) { var e = t && t.__esModule ? function () { return t.default } : function () { return t }; return n.d(e, "a", e), e }, n.o = function (t, e) { return Object.prototype.hasOwnProperty.call(t, e) }, n.p = "", n(n.s = 340) }({ 131: function (t, e, n) { var r, o; (function () { var i, s, a, u, l, c, p, h, f, d, g, m, y, v, w, b, k, S, L, x, q, T, P, O, j, R, M, A, _, E, N, C, F, U, W, X, D, H, I, z, B, G, J, K, Q, V, Y, Z, $ = [].slice, tt = {}.hasOwnProperty, et = function (t, e) { for (var n in e) tt.call(e, n) && (t[n] = e[n]); function r() { this.constructor = t } return r.prototype = e.prototype, t.prototype = new r, t.__super__ = e.prototype, t }, nt = [].indexOf || function (t) { for (var e = 0, n = this.length; e < n; e++)if (e in this && this[e] === t) return e; return -1 }; for (q = { catchupTime: 100, initialRate: .03, minTime: 250, ghostTime: 100, maxProgressPerFrame: 20, easeFactor: 1.25, startOnPageLoad: !0, restartOnPushState: !0, restartOnRequestAfter: 500, target: "body", elements: { checkInterval: 100, selectors: ["body"] }, eventLag: { minSamples: 10, sampleCount: 3, lagThreshold: 3 }, ajax: { trackMethods: ["GET"], trackWebSockets: !0, ignoreURLs: [] } }, _ = function () { var t; return null != (t = "undefined" != typeof performance && null !== performance && "function" == typeof performance.now ? performance.now() : void 0) ? t : +new Date }, N = window.requestAnimationFrame || window.mozRequestAnimationFrame || window.webkitRequestAnimationFrame || window.msRequestAnimationFrame, x = window.cancelAnimationFrame || window.mozCancelAnimationFrame, null == N && (N = function (t) { return setTimeout(t, 50) }, x = function (t) { return clearTimeout(t) }), F = function (t) { var e, n; return e = _(), (n = function () { var r; return (r = _() - e) >= 33 ? (e = _(), t(r, (function () { return N(n) }))) : setTimeout(n, 33 - r) })() }, C = function () { var t, e, n; return n = arguments[0], e = arguments[1], t = 3 <= arguments.length ? $.call(arguments, 2) : [], "function" == typeof n[e] ? n[e].apply(n, t) : n[e] }, T = function () { var t, e, n, r, o, i, s; for (e = arguments[0], i = 0, s = (r = 2 <= arguments.length ? $.call(arguments, 1) : []).length; i < s; i++)if (n = r[i]) for (t in n) tt.call(n, t) && (o = n[t], null != e[t] && "object" == typeof e[t] && null != o && "object" == typeof o ? T(e[t], o) : e[t] = o); return e }, k = function (t) { var e, n, r, o, i; for (n = e = 0, o = 0, i = t.length; o < i; o++)r = t[o], n += Math.abs(r), e++; return n / e }, O = function (t, e) { var n, r, o; if (null == t && (t = "options"), null == e && (e = !0), o = document.querySelector("[data-pace-" + t + "]")) { if (n = o.getAttribute("data-pace-" + t), !e) return n; try { return JSON.parse(n) } catch (t) { return r = t, "undefined" != typeof console && null !== console ? console.error("Error parsing inline pace options", r) : void 0 } } }, p = function () { function t() { } return t.prototype.on = function (t, e, n, r) { var o; return null == r && (r = !1), null == this.bindings && (this.bindings = {}), null == (o = this.bindings)[t] && (o[t] = []), this.bindings[t].push({ handler: e, ctx: n, once: r }) }, t.prototype.once = function (t, e, n) { return this.on(t, e, n, !0) }, t.prototype.off = function (t, e) { var n, r, o; if (null != (null != (r = this.bindings) ? r[t] : void 0)) { if (null == e) return delete this.bindings[t]; for (n = 0, o = []; n < this.bindings[t].length;)this.bindings[t][n].handler === e ? o.push(this.bindings[t].splice(n, 1)) : o.push(n++); return o } }, t.prototype.trigger = function () { var t, e, n, r, o, i, s, a, u; if (n = arguments[0], t = 2 <= arguments.length ? $.call(arguments, 1) : [], null != (s = this.bindings) ? s[n] : void 0) { for (o = 0, u = []; o < this.bindings[n].length;)r = (a = this.bindings[n][o]).handler, e = a.ctx, i = a.once, r.apply(null != e ? e : this, t), i ? u.push(this.bindings[n].splice(o, 1)) : u.push(o++); return u } }, t }(), d = window.Pace || {}, window.Pace = d, T(d, p.prototype), E = d.options = T({}, q, window.paceOptions, O()), J = 0, Q = (Y = ["ajax", "document", "eventLag", "elements"]).length; J < Q; J++)!0 === E[D = Y[J]] && (E[D] = q[D]); f = function (t) { function e() { return e.__super__.constructor.apply(this, arguments) } return et(e, t), e }(Error), s = function () { function t() { this.progress = 0 } return t.prototype.getElement = function () { var t; if (null == this.el) { if (!(t = document.querySelector(E.target))) throw new f; this.el = document.createElement("div"), this.el.className = "pace pace-active", document.body.className = document.body.className.replace(/pace-done/g, ""), document.body.className += " pace-running", this.el.innerHTML = '<div class="pace-progress">\n  <div class="pace-progress-inner"></div>\n</div>\n<div class="pace-activity"></div>', null != t.firstChild ? t.insertBefore(this.el, t.firstChild) : t.appendChild(this.el) } return this.el }, t.prototype.finish = function () { var t; return (t = this.getElement()).className = t.className.replace("pace-active", ""), t.className += " pace-inactive", document.body.className = document.body.className.replace("pace-running", ""), document.body.className += " pace-done" }, t.prototype.update = function (t) { return this.progress = t, this.render() }, t.prototype.destroy = function () { try { this.getElement().parentNode.removeChild(this.getElement()) } catch (t) { f = t } return this.el = void 0 }, t.prototype.render = function () { var t, e, n, r, o, i, s; if (null == document.querySelector(E.target)) return !1; for (t = this.getElement(), r = "translate3d(" + this.progress + "%, 0, 0)", o = 0, i = (s = ["webkitTransform", "msTransform", "transform"]).length; o < i; o++)e = s[o], t.children[0].style[e] = r; return (!this.lastRenderedProgress || this.lastRenderedProgress | 0 !== this.progress | 0) && (t.children[0].setAttribute("data-progress-text", (0 | this.progress) + "%"), this.progress >= 100 ? n = "99" : (n = this.progress < 10 ? "0" : "", n += 0 | this.progress), t.children[0].setAttribute("data-progress", "" + n)), this.lastRenderedProgress = this.progress }, t.prototype.done = function () { return this.progress >= 100 }, t }(), h = function () { function t() { this.bindings = {} } return t.prototype.trigger = function (t, e) { var n, r, o, i, s; if (null != this.bindings[t]) { for (s = [], r = 0, o = (i = this.bindings[t]).length; r < o; r++)n = i[r], s.push(n.call(this, e)); return s } }, t.prototype.on = function (t, e) { var n; return null == (n = this.bindings)[t] && (n[t] = []), this.bindings[t].push(e) }, t }(), G = window.XMLHttpRequest, B = window.XDomainRequest, z = window.WebSocket, P = function (t, e) { var n, r; for (n in r = [], e.prototype) try { null == t[n] && "function" != typeof e[n] ? "function" == typeof Object.defineProperty ? r.push(Object.defineProperty(t, n, { get: function () { return e.prototype[n] }, configurable: !0, enumerable: !0 })) : r.push(t[n] = e.prototype[n]) : r.push(void 0) } catch (t) { t } return r }, M = [], d.ignore = function () { var t, e, n; return e = arguments[0], t = 2 <= arguments.length ? $.call(arguments, 1) : [], M.unshift("ignore"), n = e.apply(null, t), M.shift(), n }, d.track = function () { var t, e, n; return e = arguments[0], t = 2 <= arguments.length ? $.call(arguments, 1) : [], M.unshift("track"), n = e.apply(null, t), M.shift(), n }, X = function (t) { var e; if (null == t && (t = "GET"), "track" === M[0]) return "force"; if (!M.length && E.ajax) { if ("socket" === t && E.ajax.trackWebSockets) return !0; if (e = t.toUpperCase(), nt.call(E.ajax.trackMethods, e) >= 0) return !0 } return !1 }, g = function (t) { function e() { var t, n = this; e.__super__.constructor.apply(this, arguments), t = function (t) { var e; return e = t.open, t.open = function (r, o, i) { return X(r) && n.trigger("request", { type: r, url: o, request: t }), e.apply(t, arguments) } }, window.XMLHttpRequest = function (e) { var n; return n = new G(e), t(n), n }; try { P(window.XMLHttpRequest, G) } catch (t) { } if (null != B) { window.XDomainRequest = function () { var e; return e = new B, t(e), e }; try { P(window.XDomainRequest, B) } catch (t) { } } if (null != z && E.ajax.trackWebSockets) { window.WebSocket = function (t, e) { var r; return r = null != e ? new z(t, e) : new z(t), X("socket") && n.trigger("request", { type: "socket", url: t, protocols: e, request: r }), r }; try { P(window.WebSocket, z) } catch (t) { } } } return et(e, t), e }(h), K = null, W = function (t) { var e, n, r, o; for (n = 0, r = (o = E.ajax.ignoreURLs).length; n < r; n++)if ("string" == typeof (e = o[n])) { if (-1 !== t.indexOf(e)) return !0 } else if (e.test(t)) return !0; return !1 }, (j = function () { return null == K && (K = new g), K })().on("request", (function (t) { var e, n, r, o, s; if (o = t.type, r = t.request, s = t.url, !W(s)) return d.running || !1 === E.restartOnRequestAfter && "force" !== X(o) ? void 0 : (n = arguments, "boolean" == typeof (e = E.restartOnRequestAfter || 0) && (e = 0), setTimeout((function () { var t, e, s, a, u; if ("socket" === o ? r.readyState < 2 : 0 < (s = r.readyState) && s < 4) { for (d.restart(), u = [], t = 0, e = (a = d.sources).length; t < e; t++) { if ((D = a[t]) instanceof i) { D.watch.apply(D, n); break } u.push(void 0) } return u } }), e)) })), i = function () { function t() { var t = this; this.elements = [], j().on("request", (function () { return t.watch.apply(t, arguments) })) } return t.prototype.watch = function (t) { var e, n, r, o; if (r = t.type, e = t.request, o = t.url, !W(o)) return n = "socket" === r ? new v(e) : new w(e), this.elements.push(n) }, t }(), w = function (t) { var e, n, r, o, i, s = this; if (this.progress = 0, null != window.ProgressEvent) for (t.addEventListener("progress", (function (t) { return t.lengthComputable ? s.progress = 100 * t.loaded / t.total : s.progress = s.progress + (100 - s.progress) / 2 }), !1), n = 0, r = (i = ["load", "abort", "timeout", "error"]).length; n < r; n++)e = i[n], t.addEventListener(e, (function () { return s.progress = 100 }), !1); else o = t.onreadystatechange, t.onreadystatechange = function () { var e; return 0 === (e = t.readyState) || 4 === e ? s.progress = 100 : 3 === t.readyState && (s.progress = 50), "function" == typeof o ? o.apply(null, arguments) : void 0 } }, v = function (t) { var e, n, r, o, i = this; for (this.progress = 0, n = 0, r = (o = ["error", "open"]).length; n < r; n++)e = o[n], t.addEventListener(e, (function () { return i.progress = 100 }), !1) }, u = function (t) { var e, n, r, o; for (null == t && (t = {}), this.elements = [], null == t.selectors && (t.selectors = []), n = 0, r = (o = t.selectors).length; n < r; n++)e = o[n], this.elements.push(new l(e)) }, l = function () { function t(t) { this.selector = t, this.progress = 0, this.check() } return t.prototype.check = function () { var t = this; return document.querySelector(this.selector) ? this.done() : setTimeout((function () { return t.check() }), E.elements.checkInterval) }, t.prototype.done = function () { return this.progress = 100 }, t }(), a = function () { function t() { var t, e, n = this; this.progress = null != (e = this.states[document.readyState]) ? e : 100, t = document.onreadystatechange, document.onreadystatechange = function () { return null != n.states[document.readyState] && (n.progress = n.states[document.readyState]), "function" == typeof t ? t.apply(null, arguments) : void 0 } } return t.prototype.states = { loading: 0, interactive: 50, complete: 100 }, t }(), c = function () { var t, e, n, r, o, i = this; this.progress = 0, t = 0, o = [], r = 0, n = _(), e = setInterval((function () { var s; return s = _() - n - 50, n = _(), o.push(s), o.length > E.eventLag.sampleCount && o.shift(), t = k(o), ++r >= E.eventLag.minSamples && t < E.eventLag.lagThreshold ? (i.progress = 100, clearInterval(e)) : i.progress = 3 / (t + 3) * 100 }), 50) }, y = function () { function t(t) { this.source = t, this.last = this.sinceLastUpdate = 0, this.rate = E.initialRate, this.catchup = 0, this.progress = this.lastProgress = 0, null != this.source && (this.progress = C(this.source, "progress")) } return t.prototype.tick = function (t, e) { var n; return null == e && (e = C(this.source, "progress")), e >= 100 && (this.done = !0), e === this.last ? this.sinceLastUpdate += t : (this.sinceLastUpdate && (this.rate = (e - this.last) / this.sinceLastUpdate), this.catchup = (e - this.progress) / E.catchupTime, this.sinceLastUpdate = 0, this.last = e), e > this.progress && (this.progress += this.catchup * t), n = 1 - Math.pow(this.progress / 100, E.easeFactor), this.progress += n * this.rate * t, this.progress = Math.min(this.lastProgress + E.maxProgressPerFrame, this.progress), this.progress = Math.max(0, this.progress), this.progress = Math.min(100, this.progress), this.lastProgress = this.progress, this.progress }, t }(), H = null, U = null, S = null, I = null, b = null, L = null, d.running = !1, R = function () { if (E.restartOnPushState) return d.restart() }, null != window.history.pushState && (V = window.history.pushState, window.history.pushState = function () { return R(), V.apply(window.history, arguments) }), null != window.history.replaceState && (Z = window.history.replaceState, window.history.replaceState = function () { return R(), Z.apply(window.history, arguments) }), m = { ajax: i, elements: u, document: a, eventLag: c }, (A = function () { var t, e, n, r, o, i, a, u; for (d.sources = H = [], e = 0, r = (i = ["ajax", "elements", "document", "eventLag"]).length; e < r; e++)!1 !== E[t = i[e]] && H.push(new m[t](E[t])); for (n = 0, o = (u = null != (a = E.extraSources) ? a : []).length; n < o; n++)D = u[n], H.push(new D(E)); return d.bar = S = new s, U = [], I = new y })(), d.stop = function () { return d.trigger("stop"), d.running = !1, S.destroy(), L = !0, null != b && ("function" == typeof x && x(b), b = null), A() }, d.restart = function () { return d.trigger("restart"), d.stop(), d.start() }, d.go = function () { var t; return d.running = !0, S.render(), t = _(), L = !1, b = F((function (e, n) { var r, o, i, s, a, u, l, c, p, h, f, g, m, v, w; for (100 - S.progress, o = h = 0, i = !0, u = f = 0, m = H.length; f < m; u = ++f)for (D = H[u], p = null != U[u] ? U[u] : U[u] = [], l = g = 0, v = (a = null != (w = D.elements) ? w : [D]).length; g < v; l = ++g)s = a[l], i &= (c = null != p[l] ? p[l] : p[l] = new y(s)).done, c.done || (o++ , h += c.tick(e)); return r = h / o, S.update(I.tick(e, r)), S.done() || i || L ? (S.update(100), d.trigger("done"), setTimeout((function () { return S.finish(), d.running = !1, d.trigger("hide") }), Math.max(E.ghostTime, Math.max(E.minTime - (_() - t), 0)))) : n() })) }, d.start = function (t) { T(E, t), d.running = !0; try { S.render() } catch (t) { f = t } return document.querySelector(".pace") ? (d.trigger("start"), d.go()) : setTimeout(d.start, 50) }, r = [n(341)], void 0 === (o = function () { return d }.apply(e, r)) || (t.exports = o) }).call(this) }, 340: function (t, e, n) { "use strict"; n.r(e); var r = n(131); function o() { setTimeout((function () { r.stop() }), 3e3) } window.paceOptions = { startOnPageLoad: !1 }, function () { if (!document.getElementById("pace-js-stylesheets")) { var t = document.createElement("style"); t.type = "text/css", t.id = "pace-js-stylesheets", t.innerHTML = "\n  .pace {\n    display: block !important;\n  }\n  .page-loader {\n    display: none;\n    position: fixed;\n    height: 2px;\n    overflow: hidden;\n    top: 0;\n    left: 0;\n    right: 0;\n    z-index: 999999;\n  }\n  .page-loader div {\n    position: absolute;\n    top: 0;\n    bottom: 0;\n    transform: translate3d(0, 0, 0);\n  }\n  .pace-running:not(.pace-done) .page-loader {\n    display: block;\n  }\n  .pace-running:not(.pace-done) .page-loader div {\n    animation-duration: 1.2s;\n    animation-name: pageLoaderAnimation;\n    animation-iteration-count: infinite;\n    animation-timing-function: ease-in-out;\n  }\n  .turbolinks-progress-bar {\n    visibility: hidden !important;\n  }\n  [dir=rtl] .pace-running:not(.pace-done) .page-loader div,\n  [dir=rtl].pace-running:not(.pace-done) .page-loader div {\n    animation-name: pageLoaderAnimationRTL;\n  }\n  @-webkit-keyframes pageLoaderAnimation {\n    0% { right: 100%; left: 0; }\n    40% { right: 0; left: 0; }\n    60% { left: 0; right: 0; }\n    100% { left: 100%; right: 0; }\n  }\n  @keyframes pageLoaderAnimation {\n    0% { right: 100%; left: 0; }\n    40% { right: 0; left: 0; }\n    60% { left: 0; right: 0; }\n    100% { left: 100%; right: 0; }\n  }\n  @-webkit-keyframes pageLoaderAnimationRTL {\n    0% { left: 100%; right: 0; }\n    40% { left: 0; right: 0; }\n    60% { right: 0; left: 0; }\n    100% { right: 100%; left: 0; }\n  }\n  @keyframes pageLoaderAnimationRTL {\n    0% { left: 100%; right: 0; }\n    40% { left: 0; right: 0; }\n    60% { right: 0; left: 0; }\n    100% { right: 100%; left: 0; }\n  }\n  ", document.querySelector("head").appendChild(t) } }(), r.start(), "complete" === document.readyState ? o() : document.addEventListener("DOMContentLoaded", o) }, 341: function (t, e) { t.exports = window['"pace-progress"'] } }));