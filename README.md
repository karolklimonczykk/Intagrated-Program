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
