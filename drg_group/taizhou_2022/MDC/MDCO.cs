namespace drg_group.taizhou_2022
{
    public class MDCO
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"O29.200","O62.406","O22.200","Z37.200x003","O86.102","O99.205","O89.000x001","O33.700x004","O35.102","O69.207","O23.500","O99.202","O94.x00","O34.005","O86.001","O31.201","O33.700x005","O35.806","O43.200x002","O99.401","O34.700x002","O08.400x003","O43.110","O99.800x321","O35.203","Z37.300","O69.001","O23.503","O70.000","O84.800","O99.800x215","Z35.900","O99.208","O60.200","O35.812","O43.111","O35.800x011","O36.303","O35.800x027","O98.600","O06.301","O89.100x002","O34.800x010","O99.800x022","O06.500","O03.601","O34.900","Z36.900","O00.104","O88.200","O99.800x231","O35.818","O23.506","O99.400x031","O83.800","Z35.802","O74.300","O36.503","O62.400x005","Z37.000x001","O99.800x216","O69.400","O36.301","O41.104","O99.217","O70.100x003","Z37.204","O66.101","O08.803","Z35.200x003","Z37.500x001","O69.500x003","O10.101","O98.804","O35.003","O99.509","O29.000x003","O35.822","O99.700x009","O82.201","O69.201","O35.803","O99.400x030","O26.800","O43.805","O45.000x004","O89.800","O99.426","O28.800","O04.300x041","Z37.700","O34.600x004","O74.600","O05.400","O68.001","Z38.300x001","O71.500","O08.102","O98.800x007","O12.100","Z35.400x001","O72.100","Z36.803","O23.505","O98.800x009","O44.101","O69.802","O34.004","O65.201","O72.201","O86.800x001","O99.800x312","O34.802","O99.008","Z37.201","Z35.207","Z37.002","O03.701","O99.104","O99.800x012","O99.800x113","Z35.200x002","O07.401","O25.x00","O28.400","O64.803","O71.100x001","O69.800x004","O98.406","O32.102","O26.000","O62.300","O22.000","O04.601","O62.402","O99.200x031","O75.200","O98.800","O99.100x012","O91.000","O34.800x015","O99.504","O00.807","O30.100","O91.201","Z37.900x003","O41.103","O64.301","O72.300x003","O65.401","O67.000","O32.900","O99.800x318","O99.421","Z37.900","O32.301","O98.400x021","O99.500x008","O99.800x021","O35.400","O10.201","O99.800x417","O35.810","O15.001","O83.000","Z37.400","O44.103","O86.802","O98.400x005","O08.100x002","O71.704","O98.502","O34.806","O64.100x003","O35.807","O99.800x211","O99.220","O99.103","O99.400x027","Z35.401","O35.800x019","O35.800x003","O03.300","O00.803","Z36.800x001","O10.401","O23.500x002","O64.501","Z37.501","O72.000","O04.800x041","O22.102","O00.902","O86.101","O08.000","O99.800x031","O35.200x003","O89.300","O63.001","O26.300","O74.700","O84.900","O92.300","O07.000x002","O03.903","O35.800x030","O07.800","O65.500x002","O35.010","O99.600x017","O89.100x001","O24.300x001","O99.700x006","O99.309","O67.800","O34.000x007","O99.600x031","O41.800","O29.000x004","O99.611","O68.003","Z35.000","O99.800x314","O98.800x033","Z35.200","O10.900x001","O99.405","O36.203","O86.400x001","O34.000x003","O44.000x001","O35.800x005","O99.425","O31.800x005","O35.816","O64.200","O35.700x006","O31.800x003","O86.002","O28.900","O70.100x004","O99.800x413","O99.800x213","O99.204","O99.600x014","O74.100","O70.100x005","O29.000x002","O35.205","O99.800x033","O35.801","O42.000x001","O00.107","O69.800x005","O03.300x061","O16.x00","O98.200","O33.002","O08.700","O13.x01","O89.400","O08.806","O62.202","O99.703","O22.103","Z37.502","O99.800x411","O91.202","O00.106","O64.800","O33.301","O75.401","O41.800x004","O35.800x028","O35.200x004","O62.400x006","O90.400x002","O08.800x007","O43.800","O92.500x002","O46.000x003","O99.803","O61.900","O61.800","O08.006","O08.200x001","O82.800","O36.300x007","O99.004","O32.803","O99.810","O35.800x026","O36.300x008","O99.814","O34.500x005","O04.300x031","O34.403","O99.430","O33.300x004","O99.505","Z38.400x001","O34.503","O10.301","O22.101","O34.003","O34.402","O35.800x007","O99.222","O44.001","O44.100","O44.100x001","O35.800x020","O26.603","O99.508","O36.302","O26.608","O73.000","O12.200","O99.200x002","O35.800x015","O08.602","O26.801","O35.300x003","O08.104","O98.800x036","O23.901","O71.200","O99.604","O69.200","O98.801","O99.807","O34.201","O73.102","O31.800x007","O32.100x004","O30.200","O99.407","O26.701","O65.501","O44.100x002","O31.000","O64.101","O35.008","O03.503","O98.900","Z38.600x001","O99.302","Z38.800x001","O64.401","O84.000","O33.201","O00.117","O99.800x315","O99.109","O75.101","O99.500x031","O21.900","O86.402","O24.400","O34.800x005","O00.102","O13.x00","O83.400","Z34.900x001","O04.001","O43.101","O02.100x002","O99.003","O03.100x001","O68.300x001","O43.806","O99.400x021","O69.501","O92.100","O98.800x035","O34.601","Z37.400x001","O04.802","O41.900","Z37.302","O08.801","O99.428","O34.000x011","O99.408","O29.900","O99.500x021","Z37.203","O99.804","O35.800x002","Z39.000x011","O28.100","O08.000x010","O71.700x001","O08.105","O00.111","O08.400x005","O99.501","O04.700x001","O29.300","O75.800x002","O28.300x001","O29.100x001","O42.100x012","O99.300x012","O35.800x023","O88.800x001","O98.302","O34.301","O74.400","O21.100x003","O99.710","O99.800x016","Z35.300x002","O20.800","O89.500","O99.503","O04.400","O99.800","O02.002","O99.809","O99.512","O98.100x021","O26.605","O04.800x061","O62.400x007","O98.811","O98.500","O70.300","O69.206","O99.702","O98.300x014","O06.600","O07.402","O22.902","Z35.500x001","O35.101","O99.420","O99.300x032","O45.000x003","O41.800x001","O03.400x001","O00.801","O02.100","O60.100x002","O29.100x002","O68.201","O99.415","O99.610","O24.000x021","O99.800x116","Z35.104","O99.107","O24.000","O99.700x021","O99.800x416","O03.501","Z35.700","O89.600","O95.x00","O96.100","O08.805","Z38.100x001","O72.000x003","O99.304","O99.800x511","O08.000x011","O98.809","O66.300x006","O99.000x021","O31.100","O62.405","O33.300x005","O84.200","O35.820","O99.800x034","O92.500x001","Z38.000x001","O36.100x002","O64.200x002","O04.801","O98.810","O35.800x018","O23.500x010","O65.300x002","O69.202","O63.100","O36.101","O62.403","O99.811","O60.001","O23.200","O43.004","O98.402","O70.900","O24.100x011","O35.821","O99.800x221","O80.800","O35.800x010","O88.100","Z36.202","O67.900","O02.800x001","O99.615","O35.206","O98.200x031","O34.404","O70.200x001","O72.002","O15.201","Z35.801","O98.300x013","O99.100x005","O65.000x001","O75.600","Z35.208","O26.601","O99.400x033","O69.503","O05.600","O34.800x004","O99.400x032","O04.800","O34.800x022","O74.800","O41.000x002","O99.105","Z36.401","O46.801","O99.400x010","O66.300x003","O00.110","O04.401","O00.809","O04.905","O87.802","Z35.200x006","O43.800x007","O99.218","O34.800x018","O99.216","Z35.101","O96.000","O99.315","O66.500x001","O26.501","O01.901","O83.200","O00.800x006","O90.800x006","O44.000x003","O88.300x001","O08.800x006","O23.500x001","O20.000","O43.803","O91.200x008","O07.300x002","O99.619","O32.302","O24.301","O00.901","O75.300x001","O99.200x018","O22.900","O08.200x002","O08.802","O99.404","O98.201","O99.311","O99.432","O71.101","O14.000x001","O34.800x012","O36.501","O34.100x011","O99.707","O99.614","O34.501","O99.511","O02.000x001","O43.001","O26.803","O98.300","O99.307","O43.005","O33.600","Z37.700x001","O81.500","O04.800x031","O08.300x003","O43.003","O99.427","O99.200x011","O04.300x081","O05.700","O36.001","O99.423","O20.900","Z37.303","Z34.800","O92.600","O04.502","O70.100x002","Z38.200x001","A34.x00","O34.800x021","O83.300","O32.101","O87.801","O23.400","O36.700x001","O04.402","O99.800x414","Z36.500","O34.502","O34.602","O04.200x001","O71.401","O89.000x004","O81.000","O34.803","Z37.200","Z35.202","O06.801","O71.402","O71.801","O03.901","O90.000","O64.100x002","O86.801","O45.900","Z37.100x002","O75.700x001","O32.201","O99.800x415","O99.800x019","O81.401","O31.200","O35.900","O00.802","O63.003","O32.303","O98.200x021","O35.300x002","O03.802","O36.002","O99.411","O91.100x001","O99.200x017","O41.101","O99.200x021","O99.221","Z37.600","O90.900","O34.102","O98.403","O69.900x001","O99.711","O07.700","Z38.700x001","O26.609","O24.100x021","O35.800x017","O61.000x002","O99.225","O65.000x002","O99.409","O99.005","O70.300x002","O01.001","O32.500","O74.000x002","O23.001","O75.800x004","O22.901","O34.800x019","O66.500x002","O81.301","O34.400x011","O34.805","O91.200x005","O99.400x011","O69.401","O03.602","O05.000","O71.700x002","O07.500","O72.300x002","O99.700x031","O70.200","O35.800x009","O99.213","O41.000","O99.704","O98.601","Z35.804","O35.800x006","O99.300x031","O35.809","O75.000","O99.609","O08.900","O62.404","O71.400","O36.401","O62.101","O61.100","O99.305","O68.002","O72.301","O34.700x004","O24.100","O14.000x002","O99.705","O36.504","O05.500","O00.200","O23.500x009","O21.100","O99.412","O46.000x004","O99.100x022","O26.100","O34.800x013","O75.300x002","O99.100x033","O71.501","O84.100","O75.500","O87.200","O34.000x013","O85.x00x006","O99.100x013","O34.000x012","O34.002","O31.800x004","O66.901","O65.800","O71.600","O68.901","O07.000","O99.800x114","O36.502","O62.100","O99.429","Z35.103","O26.806","O71.201","O99.802","O08.100x003","O98.800x032","O26.800x015","O87.301","O29.800","O99.600x021","O34.000x006","O04.500x001","O90.801","O24.200x001","O34.700","O99.206","O99.310","O35.808","O36.800","O00.115","O99.602","O63.002","O03.603","O08.000x002","O31.000x001","O26.607","O01.101","O04.701","O41.100","O34.001","O60.300x002","O01.102","O03.800","O34.000x008","O08.401","O69.500x004","O68.800","O81.200","O00.103","O71.703","O99.800x032","O75.403","O11.x01","O33.900","O03.300x031","O34.800x006","O99.312","O06.000","O34.800x017","O35.700x002","O26.400","O99.207","O26.802","O92.700","O26.602","O99.616","O26.804","O73.002","O03.800x061","O99.201","O08.000x006","O36.304","O35.006","Z64.000x001","O29.500","O99.000x031","O99.419","O03.604","O74.000x001","O90.800x008","Z39.000x031","O89.000x003","O99.800x115","O15.101","O85.x00","O40.x00","O35.700x003","O99.607","O98.401","O35.201","O99.800x421","O04.900x001","O35.805","O03.900x001","O31.800","O72.101","O66.201","O99.800x331","Z39.000x001","O08.002","O72.003","O71.601","O99.507","O07.100x001","O70.000x002","O35.500","O98.808","O99.106","O99.211","O71.802","O04.500x002","O22.500","O62.001","O30.800","O82.900","O98.301","O29.000x005","Z37.001","O64.802","O92.000","O08.005","O43.105","Z37.100","O05.301","O36.601","O70.000x005","O98.400x011","O89.900","O22.801","O34.800x011","O43.100","O74.900x001","O99.800x317","O45.001","O99.300x016","O43.802","O00.105","O36.305","O43.107","O23.504","O02.800","O98.802","O08.000x004","O24.900","O43.104","O81.100","O99.400x034","O63.901","O30.000","O00.900","Z35.206","O65.301","Z36.800x002","O34.800x014","O03.101","O80.900","O74.500","O35.814","O99.620","O99.100x023","O64.801","O89.200","O69.200x007","O98.800x037","O92.700x002","O23.000x001","O98.800x002","O34.400x009","O06.900","O43.106","O86.000","O08.500","O06.100","O99.800x132","Z35.806","O07.300x001","O66.300x001","O69.205","O99.800x316","Z35.204","O98.803","O99.200x014","O99.813","O69.210","O69.301","Z37.300x001","O00.805","O83.101","O03.800x041","Z36.300x002","O99.418","O34.600x006","O34.604","O03.002","O71.502","O91.101","O98.000","O43.102","O34.400x010","O34.101","O91.200x004","O99.223","O99.600x012","O99.801","O62.000","O99.812","O21.001","O33.800","O35.804","O08.400x004","O36.201","O22.400","O70.200x003","O91.200x007","O03.502","O69.204","O99.500x011","O06.700","O05.100","O00.201","O99.800x121","O98.501","O33.400","Z36.802","O87.900","O99.622","O71.001","O99.224","O72.300","O99.301","O35.002","O03.001","O33.700","O03.102","O87.100","O98.100","O99.506","O44.102","O99.203","O60.300x001","O69.101","O87.900x003","Z35.600x001","O99.006","O98.806","O25.x01","O99.600x018","O71.301","O32.000x001","O23.500x007","O08.301","O90.800x009","Z39.000x021","O88.300x002","O99.706","O36.900","O66.300x007","O26.600x010","O90.101","O73.001","O05.200","O75.900","Z38.500x001","O35.202","Z37.000","O99.422","O08.604","O96.900","O05.801","O99.800x112","O35.700x001","O35.800x029","O66.401","O62.800","O45.801","O70.300x001","O99.306","O46.900","O66.001","O00.000","O35.200x002","O47.900x002","O99.108","O91.001","O47.000","O35.813","O08.600x004","O35.600x001","O99.701","O92.400","O69.804","O28.502","O35.811","O98.400x031","O99.600x001","O08.103","O99.800x431","O66.300x004","O14.900","O34.200x002","O70.100","O29.400","O42.200x001","O04.300","O99.406","O23.502","O34.400x014","O00.100","O22.300","O64.900","O00.116","O35.800x012","O85.x03","O69.203","O36.100","O41.803","O04.100x002","O88.101","O62.401","O33.102","O71.202","O21.200","O71.701","O28.200","O04.000x003","O00.113","O44.000x002","O44.002","O28.000","O64.001","O99.502","O99.314","O47.900","O08.603","O90.500","O08.100x004","O99.400x008","Z35.102","O97.000","O99.400x022","O99.433","O87.300","O99.805","Z37.202","O99.709","O97.100","O99.007","O04.503","O34.500x007","O43.103","O08.300x004","O82.000","O32.202","O21.000","O32.801","O02.001","O99.431","Z37.301","O08.200x003","Z36.301","O99.101","O34.100x003","O99.510","O90.400","O06.400","O08.106","O35.004","O47.100","O08.601","O00.112","O99.100x032","O32.802","O35.823","O03.600x001","O29.000x001","O34.603","O86.401","O30.801","O91.200x003","O00.108","O33.501","O90.800x005","O03.902","O92.701","O21.100x002","O99.403","O05.900","O34.406","O35.817","O99.708","O32.601","O87.901","O43.804","O99.800x111","O99.210","O62.900","O99.700x008","O97.900","O90.800x007","O99.800x023","O03.904","O90.802","O33.000x002","O99.300x021","O98.506","O61.000x001","O07.300","O15.900","O42.900","O00.001","O48.x00","O28.501","O29.600","O99.219","O26.600x011","O99.618","O36.202","O21.100x006","O00.109","O90.202","O46.000x001","O99.800x024","O26.800x016","O35.009","O98.503","O82.100","O99.621","Z36.801","O63.000","O69.200x006","O67.000x002","O99.102","O35.005","Z37.500","O99.800x131","O41.801","O34.807","Z36.201","O99.605","O74.200x001","O98.001","O33.700x006","Z35.100","O99.313","O08.004","O08.600x005","O99.434","O43.200","O03.702","O43.807","O28.300","O90.201","O08.203","O34.405","O99.700x011","O90.102","O06.200","O65.001","O68.101","O34.500x001","O23.501","O99.303","O08.302","O98.800x013","O43.002","O46.001","Z36.400x001","O08.202","O92.100x001","O69.002","O99.808","O26.604","O03.300x041","O08.101","O34.000x009","O87.000","O07.600","O04.901","O90.800x004","O35.204","O69.209","O35.701","O02.900","O35.800x025","O98.101","O07.000x001","O34.100x001","O04.902","Z35.209","O04.600x001","O98.000x031","O08.600x006","Z34.000x001","O34.800","O99.002","O42.000x002","O86.300x001","O99.414","O65.101","O42.100x011","O43.900","Z37.600x001","O92.200","O98.805","O04.101","O35.800x001","O71.500x004","O14.200","O34.401","Z35.203","O03.200x001","O34.600x005","O26.800x013","O34.804","O34.400x013","O08.000x005","O23.300","O99.700x012","O99.601","O08.204","O36.300x009","O99.700x013","O32.401","O99.600x016","O66.300x005","O66.800","O99.617","O99.214","Z36.101","O99.800x319","O21.100x005","O99.215","O89.000x002","O23.101","O45.000","O33.101","O35.007","O88.201","O99.413","O99.402","O99.800x217","Z36.001","O86.100x002","O99.308","O43.801","O26.800x011","O69.208","O71.900","O75.801","O99.806","O03.900x002","O63.201","O70.000x003","O99.600x011","O00.804","O33.000x003","O99.424","O62.201","O21.100x004","O14.100x002","O01.902","O60.100x001","O98.000x021","O34.500x002","O99.624","O99.800x122","O12.000","O00.114","O99.410","O99.800x018","O43.112","O98.404","O99.209","O07.200x001","O99.800x412","O10.001","O85.x01","O03.800x031","O83.900","O03.504","O74.200x002","O71.403","O99.800x014","O99.300x022","O04.602","O65.900","O75.402","O46.000","O91.200x001","O99.400x023","O35.819","O34.700x005","O03.801","O98.100x031","O08.000x007","O72.202","O86.201","Z35.201","O30.900","O66.300x002","O26.606","O99.800x017","O91.102","O33.300x003","O34.701","O88.000","O44.003","O99.623","O80.100","O00.808","O99.700x010","O43.200x001","O99.212","O45.000x001","O99.603","O21.800","O71.702","O07.900x001","O99.400x004","O34.801","O08.000x009","Z35.100x001","O34.400x005","O90.300","O80.000","O00.101","O26.200","O41.102","O64.002","O99.416","O73.101","O72.001"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCO入组条件，匹配规则：主诊断匹配");
            String result;
    
            result=OB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OD1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OD2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OE1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OF1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OF2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合OQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "OQY";
            }
    
            result=OR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OS2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OT1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=OZ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCO的ADRG入组条件");
            return "";
        }
    }
}
