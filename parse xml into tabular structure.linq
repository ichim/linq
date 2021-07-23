<Query Kind="Statements" />

string xml_config = @"
					<network-computers >
						<computer ip='192.168.5.9' hostname='comp101' >
							<groups>
								<group>'accountancy'</group>
								<group>'financial'</group>
							</groups>
						</computer>
						<computer ip='192.168.5.10' hostname='comp102' >
							<groups>
								<group>'administration'</group>
							</groups>
						</computer>
					</network-computers>";
XElement network = XElement.Parse(xml_config);
var results = 	from computer in network.Elements() select 
				from groups in computer.Elements() select 
				from rol in groups.Elements() select new {rol = rol.Value, ip = (string)computer.Attribute("ip"), hostname = (string)computer.Attribute("hostname")};
var tabular = results.SelectMany(first_nested => first_nested).SelectMany(second_nested => second_nested);
tabular.Dump();






















