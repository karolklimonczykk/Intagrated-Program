# Intagrated-Program
<h2>Description</h2>
The program consists of three separate programs: <br><br>
<ul>
  <li>downloading files using the http or https protocol</li>
  <li>web browser</li>
  <li>searching for server names and addresses (acting as nslookup)</li>
</ul>
</br></br>
<p align="center">
  <img src="https://i.imgur.com/byCmJnb.png" alt="app" >
</p>

<h2>Languages and Utilities Used</h2>

- <b>C# (.NET Framework)</b>

<h2>Environments Used</h2>

- <b>Microsoft Visual Studio 2022</b>

## Downloading files using the http or https protocol
### Description
<p>
  The address of the downloaded file must be a complete URI address, i.e. it must contain the http or https prefix and the full specification of the indicated file.
</p>
<p>
  If the local name contains only a short file name, the file location is the program location.
</p>
<h3>Method used: </h3>
<ul>
  <li>DownloadFile from System.Net.WebClient Class</li>
  <li>GetFullPath from Path Class</li>
</ul>
<h3>Program walk-through</h3>
<p align="center">
Launching the application: <br/>
<img src="https://i.imgur.com/Muingly.png" width="80%" alt ="app1"/>
<br />
<br />
<p align="center">
Provide the photo's address and local name: <br/>
<img src="https://i.imgur.com/eenVlKE.png" width="80%" alt ="app1_2"/>
<br />
<br />
<p align="center">
By providing a short file name - it is saved in the program location: <br/>
<img src="https://i.imgur.com/uw3A8vU.png" width="80%" alt ="app1_3"/>
<br />
<br />
<h2>Web browser</h2>
<h3> Description </h3>
<p>
  The website address is provided in the text field. It is required to prefix it with http or https. The StartsWith method allows you to check the correctness of the address.
</p>
<p>
  The Navigate method passes the address to the control and activates the display of the web page.
</p>
<h3>Method used: </h3>
<ul>
  <li>Navigate from the control WebBrowser</li>
  <li>StartWith from class String</li>
</ul>
<h3>Program walk-through</h3>
<p align="center">
Launching the application: <br/>
<img src="https://i.imgur.com/CJ8NUB4.png" width="80%" alt ="app2"/>
<br />
<br />
<p align="center">
Provide the website address and click start: <br/>
<img src="https://i.imgur.com/CH2AoBG.png" width="80%" alt ="app2_2"/>
</p>
<br />
<br />
<h2>Searching for server names and addresses</h2>
<h3> Description </h3>
<p>
  The program searches for its own name and IP address.
</p>
<p><b>Method used:</b></p>
<ul>
  <li>GetHostName from the Dns class in the System.Net namespace</li>
  <li>IPAddress class in the System.Net namespace</li>
  <li>GetHostByName method from the Dns class returning the AddressList collection</li>
</ul>
<p>The program searches for a foreign IP address according to the given name.</p>
<p><b>Method used:</b></p>
<ul>
  <li>GetHostEntry from the Dns class in the spaceSystem.Net returns an AddressList collection</li>
  <li>Trim method of the String class that allows to remove leading and trailing blanks</li>
</ul>
<p>Search for a foreign name by given address</p>
<p><b>Method used:</b></p>
<ul>
  <li>GetHostEntry method from the Dns class in the System.Net namespace returning the HostName property</li>
  <li>Trim method of the String class that allows to remove leading and trailing blanks</li>
</ul>
<h3>Program walk-through</h3>
<p align="center">
Launching the application: <br/>
<img src="https://i.imgur.com/tUXUs8D.png" width="80%" alt ="app3"/>
<br />
<br />
<p align="center">
Provide the DNS name and IP address: <br/>
<img src="https://i.imgur.com/mTWpCXF.png" width="80%" alt ="app3_2"/>
</p>
<br />
<br />
