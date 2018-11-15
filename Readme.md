<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SaveLoadDefinition/Form1.cs) (VB: [Form1.vb](./VB/SaveLoadDefinition/Form1.vb))
<!-- default file list end -->
# How to save (load) a report definition from a file


<p>This example illustrates how to save a report definition to a <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2592">REPX file</a> (by using CodeDOM serialization mechanism) and XML file, and then restore the report from any of these files.</p>
<p><strong>NOTE</strong>:<br>Deserialization of reports obtained from untrusted parties can trigger execution of malicious code that can either be directly embedded into the report definition, or contained in an external assembly referenced by the report.<br>To avoid this, we recommend that you use <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument10011">XML serialization</a> instead of CodeDOM (in this case, reports can be safely deserialized by using the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_LoadLayoutFromXmltopic">XtraReport.LoadLayoutFromXml</a> method) and prevent any untrusted third-party libraries from becoming available on the server.<br>XML serialization is the only option for saving reports when a reporting application is deployed under the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument3860">Medium Trust permission level</a> (CodeDOM serialization is not supported in such environment).</p>

<br/>


