# LMT Blazor Utils
Interacting with elements with ease in Blazor! (updating)

<p>Dependencies: jQuery version: 3.3.1 (Js file only), jQuery UI 1.12.1 (js file and jquery-ui.css), Twitter Bootstrap 4 (css and bundle)</p>
<p>Progress tables: </p>
<p> https://studenthcmuteeduvn0-my.sharepoint.com/:x:/g/personal/15110123_student_hcmute_edu_vn/EY0L_13KbWNMvDWdVJiA37UBO4Ie7muppmIseWWXKZVEfg?e=ehPsDu</p>

<h1>I. Features</h1>

<p>This collection of libraries was created to improve Blazor developing experience. You don't need to type interop codes anymore, just work with front-end like you used to do - in Js/jQuery old style.</p>

<p>I created BlazorUtils.WebTest as a testing project. You may use it as a demo</p>

<p>LMT Blazor Utils has started only few days ago. Every comment, feedback sending to leminhtanvatc@outlook.com is appreciated.</p>
<p>Here is the list of all utils in Blazor Utils (updating)</p>

<table>
<thead>
  <tr>
    <td><b>Name</b></td>
    <td><b>Description</b></td>
    <td><b>Interface version dependencies</b></td>
    <td><b>Progress</b></td>
  </tr>
  </thead>
  <tbody>
    <tr>
      <td>Dom (BlazorUtils.Dom)</td>
      <td>Accessing and modifying DOM elements in the friendly jQuery style</td>
      <td>>= 0.2 with ver 0.1, 0.2</td>
      <td>30%</td>
    </tr>
        <tr>
      <td>Cookie (BlazorUtils.Cookie)</td>
      <td>Managing cookies</td>
      <td>>= 0.1 with ver 0.1</td>
      <td>100%</td>
    </tr>
    </tody>
</table>

<h1>II. Configurations</h1>
Things should be easy as 1, 2, 3! Just follow these steps: 
<h2>1. Add references to your project</h2>
<p>Currently, I haven't bring this to NuGet yet.</p>
<p>As an alternative, you can build the project (BlazorUtils.Dom for example) to get the dll file and add reference by yourself.</p>

<h2>2. Add BlazorUtils.0.1.js and dependencies</h2>
<p>Copy BlazorUtils.0.1.js from "\BlazorUtils.WebTest\wwwroot\js", paste in your project, call it and other dependencies' files in index.html by the <script> and <link> tags.</p>
<p>With BlazorUtils.Dom, the result should be similar to this: </p>

```
<link href="css/jquery-ui.css" rel="stylesheet"/>
<link href="css/bootstrap.min.css" rel="stylesheet"/>
<script type="text/javascript" src="js/jquery-3.3.1.min.js"></script>
<script type="text/javascript" src="js/jquery-ui.min.js"></script>
<script type="text/javascript" src="js/bootstrap.bundle.min.js"></script>
<script type="text/javascript" src="js/BlazorUtils.0.1.js"></script>
```

<p>If you use BlazorUtils.Cookie: </p>

```
<script type="text/javascript" src="js/BlazorUtils.0.1.js"></script>
```

<h2>3. Add these lines to _ViewImports.cshtml</h2>

```
@using static BlazorUtils.Dom.DomUtil
@using static BlazorUtils.Cookie.Cookies
@using BlazorUtils.Interfaces.EventArgs
```

<p>This will help you call my API faster, without calling DomUtil, Cookies over and over again.</p>
