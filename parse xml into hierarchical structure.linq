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
var results = from computer in network.Elements() select 
			new {ip=(string)computer.Attribute("ip"), hostname = (string)computer.Attribute("hostname"),
			groups = (from roles in computer.Elements() select 
			new {values = from rol in roles.Elements() select new {value = rol.Value}})};
results.Dump();














