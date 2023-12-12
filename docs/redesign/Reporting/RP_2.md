<h3 align=center>📌 Report</h3>
<hr>
<br>

<h4>MyGames</h4>
<hr>
<br>

<table style="border: 2px solid" align="center">
  <tbody>
    <tr style="border: 2px solid">
      <td align="center" colspan="4">Generals</td></tr>
    <tr>
    <tr>
      <td><strong>Name:</strong></td>
      <td>MyGames</td>
      <td><strong>Identifier:</strong></td>
      <td>RP_2</td>
    </tr>
    <tr>
      <td><strong>Objetive:</strong></td>
      <td colspan="3">The user will be able to view their match history and their respective statuses, sorted by their start date from the most recent to the oldest.</td>
    </tr>
    <tr>
      <td><strong>Access Profiles:</strong></td>
      <td colspan="3">Players</td>
    </tr>
    <tr>
      <td style="border: 2px solid" align="center" colspan="4">Actualization</td></tr>
    <tr>
      <td>Frecuency:</td>
      <td>Daily</td>
      <td>Hour:</td>
      <td>1:00</td>
    </tr>
    <tr>
      <td style="border: 2px solid" align="center" colspan="4">Access</td></tr>
    <tr>
    <tr>
      <td><strong>Format:</strong></td>
      <td colspan="3">DataTable</td>
    </tr>
    <tr>
      <td><strong>Exportable:</strong></td>
      <td> <del>Yes</del> | No </td>
      <td>Extensions:</td>
      <td>N/A</td>
    </tr>
  </tbody>
</table>
<br>

<h4>2 - Input</h4>
<hr>
<br>

<table style="border: 2px solid" align="center">
  <thead>
    <tr style="border: 2px solid">
      <th align="center">Data</th>
      <th align="center">Origin</th>
      <th align="center">Scheme</th>
      <th align="center">Entity</th>
      <th align="center">Attribute</th>
      <th align="center">Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>User</td>
      <td>Data Base</td>
      <td>Replica</td>
      <td>Game</td>
      <td>User</td>
      <td>String</td>
    </tr>
  </tbody>
</table>
<br>

<h4>3 - Process</h4>
<hr>
<br>

N/A

<h4>4 - Ouput</h4>
<hr>
<br>

<table style="border: 2px solid" align="center">
  <thead>
    <tr style="border: 2px solid">
      <th align="center">Data</th>
      <th align="center">Origin</th>
      <th align="center">Scheme</th>
      <th align="center">Entidad</th>
      <th align="center">Attribute</th>
      <th align="center">Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Game</td>
      <td>Data Base</td>
      <td>Replica</td>
      <td>Game</td>
      <td>Id</td>
      <td>Integer</td>
    </tr>
    <tr>
      <td>User</td>
      <td>Data Base</td>
      <td>Replica</td>
      <td>Game</td>
      <td>User</td>
      <td>String</td>
    </tr>
    <tr>
      <td>Status</td>
      <td>Data Base</td>
      <td>Replica</td>
      <td>Game</td>
      <td>Status</td>
      <td>String</td>
    </tr>
    <tr>
      <td>Start</td>
      <td>Data Base</td>
      <td>Replica</td>
      <td>Game</td>
      <td>Start</td>
      <td>DateTime</td>
    </tr>
      <td>Ends</td>
      <td>Data Base</td>
      <td>Replica</td>
      <td>Game</td>
      <td>End</td>
      <td>DateTime</td>
    </tr>
    <tr>
      <td>Winners</td>
      <td>Data Base</td>
      <td>Replica</td>
      <td>Game</td>
      <td>Winners</td>
      <td>String</td>
    </tr>
  </tbody>
</table>
<br>

<h4>5 - Observations</h4>
<hr>
<br>

<p>- Exception: If no data is loaded, the same view should be displayed, replacing the table and its content with the message: <i>'No matches have been loaded into the database yet.'</i><p>
<br>

<h4>6 - Demo</h4><hr>
<br>
