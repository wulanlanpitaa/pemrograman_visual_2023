<?php
 goto U376t; HA92B: $total = getTotalFields($conn, $table_name); goto hxQTI; OCQ1f: $output .= "\57\x2f\x53\151\x6d\x70\141\x6e\154\x61\x68\40\144\145\156\x67\x61\x6e\40\156\x61\x6d\141\x20\146\x69\154\145\x20\72\x20{$class_name}\56\160\150\x70\xa"; goto shapt; shapt: $output .= "\x72\145\161\165\x69\x72\145\x5f\x6f\x6e\143\145\40\x27\x64\x61\164\x61\142\x61\163\145\x2e\160\x68\x70\47\73\12"; goto xHNz0; vujQT: $class_name = ucfirst($table_name); goto QOD5T; U376t: include_once "\x64\x61\164\141\142\x61\x73\x65\56\x70\x68\x70"; goto rRT93; Mja3F: foreach ($columns as $column) { if ($column != $pk) { $output .= "\11\160\x75\142\154\151\x63\40\44{$column}\x20\x3d\40\42\x22\x3b\12"; } } goto G_btW; G_btW: $output .= "\xa\12"; goto YIoEb; hxQTI: $columns = array(); goto cTxzW; bwW4d: $output .= "\x3d\x3d\x3d\75\x3d\75\x3d\75\75\75\x3d\x3d\x3d\75\75\75\x3d\75\75\x3d\75\75\75\75\x3d\75\75\x3d\x3d\x3d\75\x3d\x3d\75\x3d\12\12"; goto sbtzg; saCYr: $table_name = $_GET["\164\141\142\x6c\145"]; goto SCw0C; fKgRm: $output .= "\x9\x9\44\x74\150\151\163\x2d\x3e\144\x62\x2d\x3e\161\x75\x65\x72\171\50\x24\x71\x75\145\162\171\51\73\12"; goto OFTSO; sfdTG: $unik = getUnique($conn, $table_name); goto HA92B; uGM6h: $output .= "\51\42\73\12\x20\40\40\40\x20\40\40\40\x24\164\150\151\x73\55\76\x64\x62\55\x3e\x71\x75\145\162\171\50\x24\161\x75\x65\x72\x79\x29\x3b\xa\40\40\40\40\40\x20\40\40\162\145\x74\x75\x72\x6e\x20\44\164\x68\151\x73\55\x3e\144\142\x2d\76\x69\x6e\163\x65\x72\x74\137\151\144\x28\x29\73\12\x20\x20\40\x20\x7d\12\12\40\40\40\40\x70\165\x62\x6c\151\143\40\x66\165\x6e\143\164\x69\157\x6e\40\165\160\144\x61\164\x65\x28\151\156\x74\x20\x24\151\144\x29\x3a\x20\x69\156\x74\12\40\x20\x20\x20\173\xa\40\40\40\x20\x20\x20\x20\x20\44\x71\x75\x65\162\x79\40\x3d\40\x22\x55\120\104\x41\124\105\40\44\x74\x68\151\163\55\x3e\164\141\x62\154\145\40\123\105\x54\x20"; goto E_16y; kHuks: foreach ($columns as $column) { if ($i < $total) { if ($column != $pk) { $output .= "\x60{$column}\x60\54"; } } else { $output .= "\x60{$column}\x60"; } $i++; } goto Vbxty; IieJk: $output .= "\x20\12\x20\40\40\40\40\x20\x20\x20\127\x48\x45\122\105\40{$pk}\40\75\40\x24\x69\x64\x22\73\12"; goto fKgRm; llYI2: $output .= "\40\xa\40\40\40\40\40\40\x20\x20\127\x48\x45\x52\x45\x20{$unik}\40\x3d\x20\x24{$unik}\x22\73\12"; goto T6ckG; nP6ii: $output .= "\x9\x9\162\x65\x74\x75\162\156\40\44\x74\150\151\x73\x2d\x3e\x64\x62\x2d\x3e\x61\x66\x66\145\x63\x74\x65\x64\137\x72\x6f\x77\163\x28\x29\73\xa"; goto Dahrx; eX7nX: $result = $conn->query($query); goto CiIA_; Dahrx: $output .= "\xa\x9\x7d\12\12\40\x20\40\x20\160\165\x62\154\x69\143\40\146\x75\156\x63\164\x69\157\x6e\x20\144\145\154\x65\x74\x65\50\151\156\164\x20\44\x69\x64\51\72\40\151\156\164\xa\x20\40\40\x20\x7b\xa\x20\x20\x20\x20\40\40\40\40\x24\161\165\145\x72\171\40\75\x20\42\x44\105\114\105\x54\105\40\106\122\x4f\x4d\x20\x24\164\x68\151\x73\55\x3e\164\141\x62\154\145\40\x57\x48\x45\122\105\40{$pk}\x20\75\x20\44\151\144\x22\73\12\x20\40\x20\x20\40\x20\40\40\x24\164\x68\151\x73\x2d\76\144\x62\x2d\x3e\x71\x75\x65\x72\x79\x28\x24\x71\x75\145\162\x79\x29\73\xa\40\x20\x20\x20\x20\x20\40\40\x72\145\164\x75\x72\x6e\40\x24\x74\x68\151\x73\55\76\x64\x62\x2d\76\x61\146\146\145\143\164\x65\x64\x5f\162\157\x77\x73\x28\x29\x3b\xa\40\x20\x20\x20\175\12\12\x20\x20\40\x20\x70\x75\142\x6c\x69\x63\40\x66\x75\x6e\x63\164\x69\157\x6e\x20\144\145\x6c\x65\x74\145\x5f\142\x79\x5f{$unik}\x28\44{$unik}\x29\72\x20\x69\156\164\12\40\40\40\40\173\12\40\40\x20\x20\x20\40\40\x20\44\161\165\145\x72\171\x20\75\x20\x22\104\x45\114\x45\124\105\x20\106\x52\x4f\115\x20\44\164\150\151\x73\x2d\x3e\x74\x61\x62\x6c\x65\40\127\x48\105\x52\105\40{$unik}\40\75\x20\44{$unik}\x22\x3b\12\40\40\x20\40\x20\40\x20\40\x24\x74\x68\x69\x73\x2d\76\x64\142\55\76\x71\165\x65\162\171\50\x24\161\x75\145\162\171\51\x3b\12\40\40\40\x20\x20\x20\40\40\x72\x65\x74\x75\x72\156\x20\44\164\x68\151\x73\55\x3e\144\142\55\x3e\x61\x66\x66\145\143\164\x65\144\x5f\x72\x6f\167\163\50\x29\73\12\40\40\40\40\175\xa\x7d\12\77\76"; goto KP3gM; CiIA_: if ($result->num_rows > 0) { while ($row = $result->fetch_assoc()) { $columns[] = $row["\x46\151\145\x6c\x64"]; } } goto vujQT; T6ckG: $output .= "\x9\x9\x24\x74\150\x69\x73\x2d\x3e\x64\142\55\76\x71\x75\x65\162\x79\50\x24\x71\165\145\x72\x79\x29\x3b\xa"; goto nP6ii; sbtzg: $output .= "\74\77\x70\150\160\12\xa"; goto OCQ1f; AAFjQ: $output .= "\103\x72\145\x61\x74\145\x64\40\x42\x79\x3a\x20\x46\162\x65\x64\x64\171\x20\x57\151\143\141\x6b\163\157\x6e\157\x2c\x20\x4d\x2e\x4b\157\x6d\12"; goto bwW4d; Vbxty: $output .= "\51\x20\126\x41\x4c\x55\105\123\40\x28"; goto IPnej; zVV6a: $i = 1; goto kHuks; rRT93: include_once "\146\x75\156\x63\x74\151\157\156\163\x2e\160\150\x70"; goto saCYr; tK4sy: foreach ($columns as $column) { if ($k < $total) { if ($column != $pk) { $output .= "{$column}\40\x3d\40\47\44\x74\x68\x69\163\x2d\x3e{$column}\x27\54\x20"; } } else { $output .= "{$column}\x20\x3d\40\47\x24\164\150\151\x73\x2d\76{$column}\47"; } $k++; } goto llYI2; vBflM: foreach ($columns as $column) { if ($j < $total) { if ($column != $pk) { $output .= "\x27\44\164\x68\x69\x73\55\x3e{$column}\x27\54"; } } else { $output .= "\x27\44\x74\150\x69\163\x2d\76{$column}\x27"; } $j++; } goto uGM6h; KP3gM: echo printCode($output); goto xZu6J; QOD5T: $output = "\123\x63\x72\x69\160\x74\x20\107\145\156\145\162\x61\164\145\144\x20\x55\x73\x69\156\x67\x20\x50\171\101\x74\x68\x6c\x6f\x6e\xa"; goto AAFjQ; YIoEb: $output .= "\12\40\x20\40\40\x70\165\142\154\151\x63\x20\x66\x75\156\x63\x74\x69\157\156\40\137\x5f\x63\157\156\163\x74\162\165\x63\x74\50\115\171\x53\x51\114\104\141\164\x61\x62\x61\163\145\40\x24\x64\142\x29\xa\40\40\x20\x20\173\12\40\40\x20\40\x20\x20\x20\40\x24\x74\150\x69\163\55\76\x64\142\40\x3d\40\x24\144\142\73\xa\40\40\x20\40\175\12\xa\40\x20\40\40\x70\x75\x62\x6c\151\143\40\146\x75\x6e\143\x74\x69\157\156\40\147\145\x74\137\141\154\x6c\50\x29\x20\12\40\x20\x20\40\173\xa\40\40\40\40\40\x20\40\40\x24\161\x75\x65\162\x79\40\75\40\x22\x53\105\114\105\103\x54\40\x2a\x20\x46\122\117\115\40\x24\164\x68\151\163\x2d\76\164\x61\142\x6c\145\42\x3b\12\40\x20\x20\40\40\40\x20\x20\x24\x72\145\163\165\x6c\x74\137\163\145\x74\x20\75\40\x24\164\x68\x69\163\55\x3e\144\142\x2d\76\161\x75\145\162\171\x28\x24\x71\165\145\162\x79\x29\x3b\xa\40\40\x20\x20\40\x20\x20\x20\x72\x65\164\165\162\156\x20\44\162\145\x73\x75\154\164\137\163\x65\x74\x3b\12\x20\x20\x20\x20\175\12\12\40\40\40\40\x70\165\x62\x6c\151\x63\40\x66\165\156\x63\164\x69\x6f\156\x20\x67\x65\164\x5f\x62\x79\x5f\x69\144\50\151\156\164\40\44\151\144\x29\xa\40\x20\40\40\x7b\xa\40\40\40\x20\40\x20\40\x20\44\x71\165\145\162\x79\x20\75\x20\42\x53\x45\114\x45\103\124\x20\x2a\x20\x46\x52\x4f\x4d\40\x24\x74\x68\x69\163\55\x3e\164\x61\142\x6c\145\x20\x57\x48\x45\x52\x45\x20\x69\144\x20\75\x20\x24\x69\x64\42\73\12\x20\40\x20\x20\40\40\x20\40\x24\x72\145\163\x75\154\x74\x5f\163\145\x74\x20\x3d\40\x24\164\x68\x69\163\55\76\x64\x62\x2d\x3e\161\165\x65\162\171\50\x24\x71\x75\x65\x72\171\51\x3b\x20\40\x20\12\40\x20\40\40\x20\40\40\x20\x72\145\164\x75\x72\x6e\40\44\162\145\163\x75\x6c\x74\137\163\x65\x74\x3b\xa\40\x20\x20\x20\175\12\12\x20\40\40\x20\160\x75\x62\154\x69\143\x20\x66\x75\156\143\164\151\157\x6e\x20\x67\x65\x74\x5f\142\171\137{$unik}\50\x69\156\164\x20\x24{$unik}\x29\12\40\x20\40\x20\173\xa\40\x20\40\40\40\40\x20\x20\x24\x71\165\145\x72\171\x20\75\40\x22\x53\105\x4c\105\103\124\40\52\40\x46\x52\x4f\115\40\x24\164\x68\x69\x73\55\76\164\141\x62\x6c\145\40\127\x48\x45\122\105\40{$unik}\40\x3d\x20\x24{$unik}\42\73\12\x20\x20\40\x20\x20\x20\40\x20\x24\162\145\163\x75\x6c\164\x5f\163\145\x74\40\x3d\40\44\164\150\151\163\55\76\x64\142\x2d\76\x71\165\x65\x72\171\50\x24\x71\165\145\x72\171\x29\73\40\x20\40\xa\40\40\x20\40\x20\40\x20\x20\162\x65\164\x75\x72\x6e\40\44\x72\145\x73\165\x6c\x74\x5f\163\x65\x74\x3b\xa\40\x20\40\40\175\12\xa\40\x20\x20\40\160\165\142\154\x69\143\x20\146\165\x6e\143\x74\x69\x6f\x6e\40\x69\x6e\163\145\162\x74\x28\51\72\40\151\x6e\x74\xa\x20\x20\40\x20\173\12\40\x20\40\40\x20\x20\x20\x20\x24\161\x75\145\x72\171\40\75\40\x22\x49\x4e\x53\105\122\x54\40\111\116\x54\117\x20\44\x74\x68\x69\x73\x2d\x3e\164\x61\x62\154\145\40\x28"; goto zVV6a; Tt2PP: $k = 1; goto tK4sy; IPnej: $j = 1; goto vBflM; xHNz0: $output .= "\143\x6c\x61\163\163\x20{$class_name}\40\12\173\xa\x20\x20\x20\x20\x70\x72\x69\166\x61\164\x65\40\x24\x64\142\73\12\x20\40\40\40\160\162\151\x76\x61\x74\x65\x20\44\164\141\142\x6c\145\40\75\40\47{$table_name}\x27\x3b\12"; goto Mja3F; cTxzW: $query = "\x53\x48\117\127\40\x43\x4f\114\x55\x4d\116\123\40\x46\x52\x4f\115\x20{$table_name}"; goto eX7nX; vuA48: $output .= "\xa\11\x7d\xa\12\x20\x20\x20\40\x70\x75\142\154\x69\143\x20\x66\x75\x6e\x63\x74\151\x6f\x6e\40\165\x70\144\x61\x74\x65\137\142\x79\137{$unik}\x28\44{$unik}\x29\x3a\x20\x69\156\x74\xa\40\x20\40\x20\x7b\12\x20\x20\x20\x20\x20\x20\40\40\44\x71\x75\x65\x72\171\x20\75\40\x22\125\x50\104\x41\124\105\x20\x24\x74\x68\x69\x73\x2d\76\164\141\x62\154\145\x20\123\105\x54\x20"; goto Tt2PP; SCw0C: $pk = getPrimaryKey($conn, $table_name); goto sfdTG; E_16y: $k = 1; goto xca7v; OFTSO: $output .= "\11\x9\162\145\x74\165\x72\x6e\x20\44\x74\150\151\x73\x2d\76\144\x62\55\x3e\x61\x66\146\145\143\x74\x65\x64\137\162\157\167\x73\x28\51\73\12"; goto vuA48; xca7v: foreach ($columns as $column) { if ($k < $total) { if ($column != $pk) { $output .= "{$column}\40\75\x20\x27\x24\164\150\151\x73\x2d\76{$column}\47\x2c\x20"; } } else { $output .= "{$column}\40\75\x20\x27\x24\164\150\151\163\x2d\76{$column}\x27"; } $k++; } goto IieJk; xZu6J: ?>