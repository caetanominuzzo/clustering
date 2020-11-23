using Aglomera;
using Aglomera.Linkage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clustering.forms
{


    public enum tipos
    {
        euclidean,
        geodesic,
        angularEuclidean
    }

    public partial class Form1 : Form
    {
        #region tt

        DataPoint<int>[] dataa = new DataPoint<int>[]
          {
                new DataPoint<int>(-23.50416080,-46.70000240,-23.49157200,-46.72427500),
                new DataPoint<int>(-23.52517530,-46.67788610,-23.53588400,-46.79633700)
          };

        DataPoint<int>[] data = new DataPoint<int>[]
          {
                new DataPoint<int>(-23.50416080,-46.70000240,-23.49157200,-46.72427500),
new DataPoint<int>(-23.61415140,-46.77898120,-23.65357900,-46.66284200),
new DataPoint<int>(-23.61415140,-46.77898120,-23.54352500,-46.66068500),
new DataPoint<int>(-23.61415140,-46.77898120,-23.51906200,-46.69958900),
new DataPoint<int>(-23.61415140,-46.77898120,-23.58341100,-46.56964500),
new DataPoint<int>(-23.67272840,-46.53122670,-23.59768970,-46.57719830),
new DataPoint<int>(-23.59445070,-46.59865660,-23.54474500,-46.60245300),
new DataPoint<int>(-23.50475400,-46.61171440,-23.56822060,-46.55892700),
new DataPoint<int>(-23.50475400,-46.61171440,-23.49778000,-46.64081310),
new DataPoint<int>(-23.59445070,-46.59865660,-23.61143500,-46.63054900),
new DataPoint<int>(-23.64173570,-46.53716830,-23.48390310,-46.54183480),
new DataPoint<int>(-23.55887650,-46.54753650,-23.53382900,-46.45701900),
new DataPoint<int>(-23.70127900,-46.53886300,-23.60466700,-46.57248610),
new DataPoint<int>(-23.56550980,-46.57814210,-23.49724400,-46.84724400),
new DataPoint<int>(-23.56550980,-46.57814210,-23.57360400,-46.83446500),
new DataPoint<int>(-23.56550980,-46.57814210,-23.53363400,-46.77464100),
new DataPoint<int>(-23.56550980,-46.57814210,-23.65808200,-46.52132000),
new DataPoint<int>(-23.56550980,-46.57814210,-23.37873300,-46.44277900),
new DataPoint<int>(-23.56550980,-46.57814210,-23.54122500,-46.68311600),
new DataPoint<int>(-23.56550980,-46.57814210,-23.58579000,-46.54255500),
new DataPoint<int>(-23.56096470,-46.69819960,-23.62268000,-46.67336060),
new DataPoint<int>(-23.53307950,-46.61316930,-23.56364040,-46.67925380),
new DataPoint<int>(-23.62671250,-46.62152840,-23.52073200,-46.70953100),
new DataPoint<int>(-23.55947760,-46.65056010,-23.57883990,-46.55050670),
new DataPoint<int>(-23.49230640,-46.71920900,-23.52885890,-46.67310190),
new DataPoint<int>(-23.58228550,-46.61413710,-23.54561780,-46.75020770),
new DataPoint<int>(-23.69124840,-46.56686750,-23.60118500,-46.62721000),
new DataPoint<int>(-23.56550980,-46.57814210,-23.48218200,-46.72042440),
new DataPoint<int>(-23.69124840,-46.56686750,-23.61232200,-46.52082300),
new DataPoint<int>(-23.53786350,-46.50515260,-23.61404600,-46.46430240),
new DataPoint<int>(-23.49230640,-46.71920900,-23.60234460,-46.67673980),
new DataPoint<int>(-23.69124840,-46.56686750,-23.68096200,-46.55971600),
new DataPoint<int>(-23.49230640,-46.71920900,-23.49001930,-46.67847140),
new DataPoint<int>(-23.69124840,-46.56686750,-23.62232180,-46.56580630),
new DataPoint<int>(-23.49230640,-46.71920900,-23.62292720,-46.63781010),
new DataPoint<int>(-23.69124840,-46.56686750,-23.73356400,-46.58993000),
new DataPoint<int>(-23.59445070,-46.59865660,-23.55254300,-46.57467610),
new DataPoint<int>(-23.67977170,-46.68420910,-23.59884800,-46.63061700),
new DataPoint<int>(-23.52517530,-46.67788610,-23.53588400,-46.79633700),
new DataPoint<int>(-23.52517530,-46.67788610,-23.55164200,-46.65063800),
new DataPoint<int>(-23.52517530,-46.67788610,-23.53401500,-46.65158100),
new DataPoint<int>(-23.52517530,-46.67788610,-23.52730400,-46.72743400),
new DataPoint<int>(-23.52517530,-46.67788610,-23.60160100,-46.61692200),
new DataPoint<int>(-23.52517530,-46.67788610,-23.48717500,-46.60699800),
new DataPoint<int>(-23.52517530,-46.67788610,-23.60625800,-46.51341700),
new DataPoint<int>(-23.56081570,-46.62493260,-23.56105350,-46.64770420),
new DataPoint<int>(-23.54039200,-46.60065900,-23.53318200,-46.67121300),
new DataPoint<int>(-23.52517530,-46.67788610,-23.53423000,-46.57811000),
new DataPoint<int>(-23.52227170,-46.83603410,-23.52605900,-46.85229290),
new DataPoint<int>(-23.56725280,-46.61456040,-23.61600280,-46.73240910),
new DataPoint<int>(-23.55947760,-46.65056010,-23.66640080,-46.64745480),
new DataPoint<int>(-23.59445070,-46.59865660,-23.58517780,-46.68898380),
new DataPoint<int>(-23.65532950,-46.70352570,-23.60400700,-46.73297000),
new DataPoint<int>(-23.70471410,-46.55561600,-23.55288000,-46.49887100),
new DataPoint<int>(-23.53307950,-46.61316930,-23.57907680,-46.55520660),
new DataPoint<int>(-23.49310480,-46.56831040,-23.62393600,-46.66907900),
new DataPoint<int>(-23.57621400,-46.57583850,-23.51071950,-46.54290950),
new DataPoint<int>(-23.49230640,-46.71920900,-23.55276270,-46.69932450),
new DataPoint<int>(-23.55707570,-46.60302510,-23.63584000,-46.73339400),
new DataPoint<int>(-23.55349750,-46.57095100,-23.55921700,-46.67243100),
new DataPoint<int>(-23.55707570,-46.60302510,-23.47446800,-46.84094300),
new DataPoint<int>(-23.71172270,-46.53718870,-23.56232900,-46.65168660),
new DataPoint<int>(-23.54191640,-46.61199290,-23.67295400,-46.50319600),
new DataPoint<int>(-23.67272840,-46.53122670,-23.58382240,-46.63478070),
new DataPoint<int>(-23.54191640,-46.61199290,-23.44269500,-46.52194500),
new DataPoint<int>(-23.61304600,-46.49428630,-23.58846100,-46.48833000),
new DataPoint<int>(-23.55707570,-46.60302510,-23.53355100,-46.66805800),
new DataPoint<int>(-23.67272840,-46.53122670,-23.55633420,-46.60429110),
new DataPoint<int>(-23.58407430,-46.62670790,-23.60267500,-46.67319900),
new DataPoint<int>(-23.54191640,-46.61199290,-23.65375100,-46.80413400),
new DataPoint<int>(-23.55707570,-46.60302510,-23.55406600,-46.58067300),
new DataPoint<int>(-23.54191640,-46.61199290,-23.54460000,-46.88641500),
new DataPoint<int>(-23.55738040,-46.60707100,-23.54101330,-46.59636180),
new DataPoint<int>(-23.54191640,-46.61199290,-23.54926400,-46.83046000),
new DataPoint<int>(-23.56407220,-46.67154530,-23.55941010,-46.65099080),
new DataPoint<int>(-23.54191640,-46.61199290,-23.71827000,-46.55437200),
new DataPoint<int>(-23.54191640,-46.61199290,-23.48951300,-46.39711700),
new DataPoint<int>(-23.54191640,-46.61199290,-23.57060100,-46.63667000),
new DataPoint<int>(-23.54191640,-46.61199290,-23.53015500,-46.60309000),
new DataPoint<int>(-23.54191640,-46.61199290,-23.52114900,-46.48188400),
new DataPoint<int>(-23.54191640,-46.61199290,-23.63693500,-46.60443100),
new DataPoint<int>(-23.46593150,-46.63676730,-23.58611900,-46.67624800),
new DataPoint<int>(-23.46593150,-46.63676730,-23.50427400,-46.78183200),
new DataPoint<int>(-23.54191640,-46.61199290,-23.65577000,-46.69294100),
new DataPoint<int>(-23.61432910,-46.61959700,-23.66379300,-46.56074400),
new DataPoint<int>(-23.54191640,-46.61199290,-23.51977600,-46.72486200),
new DataPoint<int>(-23.54191640,-46.61199290,-23.54390000,-46.63945700),
new DataPoint<int>(-23.49576790,-46.84688870,-23.52087400,-46.71368600),
new DataPoint<int>(-23.49230640,-46.71920900,-23.43604000,-46.74344270),
new DataPoint<int>(-23.56281910,-46.66466190,-23.54787500,-46.63691600),
new DataPoint<int>(-23.67363880,-46.51328730,-23.60730000,-46.67370800),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56370700,-46.67139200),
new DataPoint<int>(-23.51291800,-46.65064740,-23.60473100,-46.51281900),
new DataPoint<int>(-23.51291800,-46.65064740,-23.50470300,-46.67265400),
new DataPoint<int>(-23.56281910,-46.66466190,-23.57109900,-46.65478200),
new DataPoint<int>(-23.51291800,-46.65064740,-23.48152100,-46.76169400),
new DataPoint<int>(-23.51291800,-46.65064740,-23.54962500,-46.61137200),
new DataPoint<int>(-23.51291800,-46.65064740,-23.54603100,-46.57057600),
new DataPoint<int>(-23.51291800,-46.65064740,-23.55679900,-46.61771300),
new DataPoint<int>(-23.51291800,-46.65064740,-23.65690800,-46.61113500),
new DataPoint<int>(-23.51291800,-46.65064740,-23.56871300,-46.59478800),
new DataPoint<int>(-23.51291800,-46.65064740,-23.52202800,-46.53849500),
new DataPoint<int>(-23.51291800,-46.65064740,-23.51417300,-46.44999800),
new DataPoint<int>(-23.58634730,-46.74613050,-23.60721070,-46.71870310),
new DataPoint<int>(-23.54060270,-46.63970300,-23.48604830,-46.57842700),
new DataPoint<int>(-23.53704180,-46.65331520,-23.57199500,-46.61972900),
new DataPoint<int>(-23.50177880,-46.61290860,-23.64943300,-46.65095700),
new DataPoint<int>(-23.53640530,-46.63816640,-23.59716130,-46.68342110),
new DataPoint<int>(-23.56281910,-46.66466190,-23.55656300,-46.66905700),
new DataPoint<int>(-23.59330970,-46.48703220,-23.64385160,-46.63523320),
new DataPoint<int>(-23.56702800,-46.74797380,-23.53248400,-46.60921700),
new DataPoint<int>(-23.55349750,-46.57095100,-23.56523220,-46.66658090),
new DataPoint<int>(-23.56702800,-46.74797380,-23.68086100,-46.54597900),
new DataPoint<int>(-23.56702800,-46.74797380,-23.47360200,-46.83076400),
new DataPoint<int>(-23.54191640,-46.61199290,-23.54628400,-46.74882000),
new DataPoint<int>(-23.53629880,-46.66745650,-23.50904000,-46.67400100),
new DataPoint<int>(-23.53629880,-46.66745650,-23.57260400,-46.66042900),
new DataPoint<int>(-23.53953890,-46.63927190,-23.66801400,-46.64698400),
new DataPoint<int>(-23.52471070,-46.56971370,-23.52764800,-46.41957000),
new DataPoint<int>(-23.53953890,-46.63927190,-23.57396700,-46.52974600),
new DataPoint<int>(-23.53953890,-46.63927190,-23.48629900,-46.61323300),
new DataPoint<int>(-23.60181740,-46.68522910,-23.49226900,-46.62588200),
new DataPoint<int>(-23.61963150,-46.67132900,-23.57598800,-46.74138500),
new DataPoint<int>(-23.61963150,-46.67132900,-23.58051400,-46.64451000),
new DataPoint<int>(-23.61963150,-46.67132900,-23.59874400,-46.63481800),
new DataPoint<int>(-23.53953890,-46.63927190,-23.64680700,-46.52137400),
new DataPoint<int>(-23.63065530,-46.58996060,-23.57445400,-46.73442100),
new DataPoint<int>(-23.49310480,-46.56831040,-23.55730900,-46.40835700),
new DataPoint<int>(-23.49343770,-46.67562500,-23.50603030,-46.74794980),
new DataPoint<int>(-23.61415140,-46.77898120,-23.55715900,-46.69275500),
new DataPoint<int>(-23.49343770,-46.67562500,-23.44606220,-46.61239220),
new DataPoint<int>(-23.52826790,-46.53694500,-23.54305300,-46.64791400),
new DataPoint<int>(-23.65705110,-46.70392890,-23.62306590,-46.70226260),
new DataPoint<int>(-23.49230640,-46.71920900,-23.57512080,-46.70669080),
new DataPoint<int>(-23.61963150,-46.67132900,-23.62209700,-46.56860800),
new DataPoint<int>(-23.49556160,-46.79278120,-23.61163860,-46.78873420),
new DataPoint<int>(-23.53781350,-46.64284550,-23.53455050,-46.59541680),
new DataPoint<int>(-23.56208780,-46.82685450,-23.56176540,-46.83300560),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56051400,-46.66153500),
new DataPoint<int>(-23.53021450,-46.69351710,-23.48865900,-46.66741870),
new DataPoint<int>(-23.53953890,-46.63927190,-23.66795200,-46.80406200),
new DataPoint<int>(-23.56794760,-46.64783710,-23.62643750,-46.49664680),
new DataPoint<int>(-23.51993100,-46.57013940,-23.56916720,-46.51023460),
new DataPoint<int>(-23.51993100,-46.57013940,-23.61047980,-46.66091090),
new DataPoint<int>(-23.51993100,-46.57013940,-23.51162550,-46.58273600),
new DataPoint<int>(-23.56281910,-46.66466190,-23.58254300,-46.64687300),
new DataPoint<int>(-23.56208780,-46.82685450,-23.56176540,-46.83300560),
new DataPoint<int>(-23.53629880,-46.66745650,-23.65937190,-46.66591190),
new DataPoint<int>(-23.50475400,-46.61171440,-23.48350200,-46.56667900),
new DataPoint<int>(-23.50475400,-46.61171440,-23.51783500,-46.57620100),
new DataPoint<int>(-23.50475400,-46.61171440,-23.55849500,-46.66248600),
new DataPoint<int>(-23.50475400,-46.61171440,-23.62170200,-46.60437500),
new DataPoint<int>(-23.50475400,-46.61171440,-23.59951500,-46.66501700),
new DataPoint<int>(-23.50688610,-46.51638630,-23.62095720,-46.46095220),
new DataPoint<int>(-23.56550980,-46.57814210,-23.57143550,-46.64937410),
new DataPoint<int>(-23.64249720,-46.67924040,-23.64163000,-46.75860400),
new DataPoint<int>(-23.64249720,-46.67924040,-23.53118400,-46.55452200),
new DataPoint<int>(-23.54284280,-46.64855540,-23.55894300,-46.67779100),
new DataPoint<int>(-23.54191640,-46.61199290,-23.51419200,-46.83742100),
new DataPoint<int>(-23.48498980,-46.62293690,-23.49364890,-46.58040740),
new DataPoint<int>(-23.56096470,-46.69819960,-23.54752140,-46.65995560),
new DataPoint<int>(-23.56096470,-46.69819960,-23.57639480,-46.68801030),
new DataPoint<int>(-23.54191640,-46.61199290,-23.43639900,-46.57125400),
new DataPoint<int>(-23.54191640,-46.61199290,-23.50230300,-46.51747900),
new DataPoint<int>(-23.54191640,-46.61199290,-23.52716000,-46.63650000),
new DataPoint<int>(-23.48498980,-46.62293690,-23.45204060,-46.57997720),
new DataPoint<int>(-23.54191640,-46.61199290,-23.71339600,-46.57911100),
new DataPoint<int>(-23.48498980,-46.62293690,-23.45942840,-46.70057950),
new DataPoint<int>(-23.64173570,-46.53716830,-23.45864100,-46.46783100),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56010500,-46.66728500),
new DataPoint<int>(-23.53953890,-46.63927190,-23.56802100,-46.62975700),
new DataPoint<int>(-23.63263480,-46.64370070,-23.64208500,-46.66175000),
new DataPoint<int>(-23.63263480,-46.64370070,-23.62564300,-46.62273300),
new DataPoint<int>(-23.63263480,-46.64370070,-23.61598400,-46.62273800),
new DataPoint<int>(-23.56281910,-46.66466190,-23.58036300,-46.65429600),
new DataPoint<int>(-23.63263480,-46.64370070,-23.55067700,-46.69169100),
new DataPoint<int>(-23.48449740,-46.61394670,-23.43140000,-46.58124900),
new DataPoint<int>(-23.56281910,-46.66466190,-23.55958500,-46.67402800),
new DataPoint<int>(-29.94195390,-51.06275640,-22.77130260,-47.33583820),
new DataPoint<int>(-23.63263480,-46.64370070,-23.61991000,-46.63816400),
new DataPoint<int>(-29.94195390,-51.06275640,-29.93407570,-51.06155380),
new DataPoint<int>(-29.94195390,-51.06275640,-29.92832100,-51.05730660),
new DataPoint<int>(-23.56281910,-46.66466190,-23.55110900,-46.67021400),
new DataPoint<int>(-23.56281910,-46.66466190,-23.55996100,-46.66834800),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56181100,-46.66647900),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56775400,-46.65435200),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56240100,-46.66634200),
new DataPoint<int>(-23.63263480,-46.64370070,-23.61402900,-46.68164600),
new DataPoint<int>(-23.56281910,-46.66466190,-23.57880600,-46.67186000),
new DataPoint<int>(-23.63263480,-46.64370070,-23.64480300,-46.65337600),
new DataPoint<int>(-23.56281910,-46.66466190,-23.57050600,-46.65745600),
new DataPoint<int>(-23.56281910,-46.66466190,-23.57266000,-46.65897300),
new DataPoint<int>(-23.63263480,-46.64370070,-23.63118800,-46.66716700),
new DataPoint<int>(-23.63263480,-46.64370070,-23.55415700,-46.67532100),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56477100,-46.65962000),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56007200,-46.65659700),
new DataPoint<int>(-29.91543710,-51.05204900,-23.57033840,-46.64515620),
new DataPoint<int>(-29.91543710,-51.05204900,-23.57105470,-46.64425070),
new DataPoint<int>(-23.53895090,-46.63757510,-23.56027660,-46.62186180),
new DataPoint<int>(-23.62730600,-46.59258240,-23.48399420,-46.62851100),
new DataPoint<int>(-29.94195390,-51.06275640,-29.93407570,-51.06155380),
new DataPoint<int>(-23.56550980,-46.57814210,-23.49528980,-46.37140750),
new DataPoint<int>(-29.94215990,-51.06273300,-29.92977010,-51.04692140),
new DataPoint<int>(-23.55266600,-46.85222290,-23.52916400,-46.64836900),
new DataPoint<int>(-23.56550980,-46.57814210,-23.61961100,-46.57062000),
new DataPoint<int>(-23.52517530,-46.67788610,-23.70794200,-46.71019400),
new DataPoint<int>(-23.56550980,-46.57814210,-23.66539000,-46.56476600),
new DataPoint<int>(-23.56550980,-46.57814210,-23.56882100,-46.70854800),
new DataPoint<int>(-23.52517530,-46.67788610,-23.54588400,-46.69941900),
new DataPoint<int>(-23.56550980,-46.57814210,-23.64318500,-46.80484600),
new DataPoint<int>(-23.52517530,-46.67788610,-23.51839500,-46.68440000),
new DataPoint<int>(-23.56550980,-46.57814210,-23.59671950,-46.72596960),
new DataPoint<int>(-23.61104240,-46.54889560,-23.56381510,-46.63701640),
new DataPoint<int>(-23.51578380,-46.62627250,-23.51318600,-46.50217800),
new DataPoint<int>(-23.48617190,-46.66001910,-23.50458200,-46.68403600),
new DataPoint<int>(-23.71947970,-46.54623600,-23.55969300,-46.52985800),
new DataPoint<int>(-23.54191640,-46.61199290,-23.53535800,-46.84493600),
new DataPoint<int>(-23.55738040,-46.60707100,-23.58281870,-46.64149330),
new DataPoint<int>(-23.54191640,-46.61199290,-23.49447800,-46.46882700),
new DataPoint<int>(-23.54191640,-46.61199290,-23.65530200,-46.64033900),
new DataPoint<int>(-23.54191640,-46.61199290,-23.59062400,-46.72598000),
new DataPoint<int>(-23.54191640,-46.61199290,-23.61036900,-46.44945000),
new DataPoint<int>(-23.54191640,-46.61199290,-23.53971400,-46.60203800),
new DataPoint<int>(-23.50475400,-46.61171440,-23.52811600,-46.65644400),
new DataPoint<int>(-23.50475400,-46.61171440,-23.59283700,-46.50007900),
new DataPoint<int>(-23.50475400,-46.61171440,-23.57234500,-46.68423400),
new DataPoint<int>(-23.50475400,-46.61171440,-23.58967200,-46.63278100),
new DataPoint<int>(-23.67977170,-46.68420910,-23.58854800,-46.63758600),
new DataPoint<int>(-23.46593150,-46.63676730,-23.57137300,-46.76765200),
new DataPoint<int>(-23.53704180,-46.65331520,-23.62165100,-46.67672100),
new DataPoint<int>(-23.61304600,-46.49428630,-23.55758200,-46.55154100),
new DataPoint<int>(-23.49310480,-46.56831040,-23.49583300,-46.63641700),
new DataPoint<int>(-23.49310480,-46.56831040,-23.51997900,-46.66583800),
new DataPoint<int>(-23.49310480,-46.56831040,-23.40162900,-46.42143700),
new DataPoint<int>(-23.59471220,-46.55005290,-23.51925400,-46.65380300),
new DataPoint<int>(-23.60901810,-46.63844070,-23.69302670,-46.69766140),
new DataPoint<int>(-5.88210000,-35.17760000,-5.88102810,-35.17912810),
new DataPoint<int>(-23.63971000,-46.55923540,-23.65958500,-46.55102200),
new DataPoint<int>(-23.56550980,-46.57814210,-23.51547800,-46.53444400),
new DataPoint<int>(-23.61393370,-46.77877920,-23.48135800,-46.62914000),
new DataPoint<int>(-23.55349750,-46.57095100,-23.46037560,-46.53359760),
new DataPoint<int>(-23.70471410,-46.55561600,-23.46633000,-46.65533700),
new DataPoint<int>(-23.61104240,-46.54889560,-23.58490350,-46.61908950),
new DataPoint<int>(-23.55707570,-46.60302510,-23.47880100,-46.56841100),
new DataPoint<int>(-23.66551550,-46.55804080,-23.59190800,-46.72349900),
new DataPoint<int>(-23.54191640,-46.61199290,-23.53361900,-46.61486400),
new DataPoint<int>(-23.61432910,-46.61959700,-23.59090300,-46.60708500),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56588200,-46.66791300),
new DataPoint<int>(-23.54191640,-46.61199290,-23.57733700,-46.51269300),
new DataPoint<int>(-23.51291800,-46.65064740,-23.60158100,-46.79315000),
new DataPoint<int>(-23.51291800,-46.65064740,-23.53843300,-46.65355800),
new DataPoint<int>(-23.52471070,-46.56971370,-23.52824600,-46.73077500),
new DataPoint<int>(-23.61432910,-46.61959700,-23.58490400,-46.61909000),
new DataPoint<int>(-23.67363880,-46.51328730,-23.54734400,-46.64296800),
new DataPoint<int>(-23.61963150,-46.67132900,-23.53460700,-46.76871400),
new DataPoint<int>(-23.52826790,-46.53694500,-23.55143100,-46.63557800),
new DataPoint<int>(-23.61393370,-46.77877920,-23.54344900,-46.55395700),
new DataPoint<int>(-23.50475400,-46.61171440,-23.55330500,-46.52457800),
new DataPoint<int>(-23.61415140,-46.77898120,-23.46193500,-46.62514400),
new DataPoint<int>(-23.61415140,-46.77898120,-23.56474200,-46.68658200),
new DataPoint<int>(-23.49415990,-46.63126770,-23.52263780,-46.62883040),
new DataPoint<int>(-23.53704180,-46.65331520,-23.55392600,-46.57844400),
new DataPoint<int>(-23.56281910,-46.66466190,-23.58254300,-46.64687300),
new DataPoint<int>(-23.53640530,-46.63816640,-23.46346590,-46.65314300),
new DataPoint<int>(-23.65705110,-46.70392890,-23.66911270,-46.64097780),
new DataPoint<int>(-23.50177880,-46.61290860,-23.59400000,-46.67385400),
new DataPoint<int>(-23.50177880,-46.61290860,-23.47608820,-46.54439900),
new DataPoint<int>(-23.51993100,-46.57013940,-23.53371670,-46.56764850),
new DataPoint<int>(-23.51993100,-46.57013940,-23.66874870,-46.67343870),
new DataPoint<int>(-23.55518130,-46.61347730,-23.57432200,-46.61566500),
new DataPoint<int>(-23.71172270,-46.53718870,-23.55372310,-46.65724020),
new DataPoint<int>(-23.53629880,-46.66745650,-23.55262700,-46.60663700),
new DataPoint<int>(-23.56208780,-46.82685450,-23.56176540,-46.83300560),
new DataPoint<int>(-23.54191640,-46.61199290,-23.47211600,-46.52265900),
new DataPoint<int>(-23.48498980,-46.62293690,-23.44977130,-46.54282190),
new DataPoint<int>(-23.56747300,-46.54317610,-23.52528900,-46.60322000),
new DataPoint<int>(-23.53953890,-46.63927190,-23.55857100,-46.62044100),
new DataPoint<int>(-23.54191640,-46.61199290,-23.67186000,-46.54044400),
new DataPoint<int>(-23.68111250,-46.68309720,-23.51633100,-46.78410400),
new DataPoint<int>(-23.54191640,-46.61199290,-23.64872100,-46.72086200),
new DataPoint<int>(-23.54191640,-46.61199290,-23.47704900,-46.75446200),
new DataPoint<int>(-23.54191640,-46.61199290,-23.54487500,-46.53808300),
new DataPoint<int>(-23.54191640,-46.61199290,-23.55925500,-46.43391600),
new DataPoint<int>(-23.56550980,-46.57814210,-23.59450810,-46.73370880),
new DataPoint<int>(-23.48498980,-46.62293690,-23.52797760,-46.55851390),
new DataPoint<int>(-23.48498980,-46.62293690,-23.48046280,-46.61034320),
new DataPoint<int>(-5.88210000,-35.17760000,-5.88150880,-35.17855210),
new DataPoint<int>(-5.88210000,-35.17760000,-5.88206920,-35.17789140),
new DataPoint<int>(-5.88210000,-35.17760000,-5.88253340,-35.17744420),
new DataPoint<int>(-23.56794760,-46.64783710,-23.51841700,-46.72426100),
new DataPoint<int>(-29.91543710,-51.05204900,-23.19943480,-47.28777840),
new DataPoint<int>(-29.91543710,-51.05204900,-23.57848970,-46.60257780),
new DataPoint<int>(-23.56096470,-46.69819960,-23.62268000,-46.67336060),
new DataPoint<int>(-5.88210000,-35.17760000,-5.88213250,-35.17782470),
new DataPoint<int>(-23.56096470,-46.69819960,-23.54209540,-46.66364310),
new DataPoint<int>(-5.88210000,-35.17760000,-5.88120700,-35.17889930),
new DataPoint<int>(-23.56281910,-46.66466190,-23.55771500,-46.67650800),
new DataPoint<int>(-23.63263480,-46.64370070,-23.63359900,-46.64258500),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56313700,-46.64100200),
new DataPoint<int>(-23.63263480,-46.64370070,-23.61146500,-46.64177900),
new DataPoint<int>(-23.56281910,-46.66466190,-23.55327600,-46.67580900),
new DataPoint<int>(-23.55947760,-46.65056010,-23.54850200,-46.63910560),
new DataPoint<int>(-23.63263480,-46.64370070,-23.63889500,-46.63802500),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56231300,-46.66611200),
new DataPoint<int>(-23.56281910,-46.66466190,-23.58240900,-46.67325100),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56085900,-46.66445500),
new DataPoint<int>(-23.56281910,-46.66466190,-23.57893700,-46.67186200),
new DataPoint<int>(-23.56281910,-46.66466190,-23.58107300,-46.67848300),
new DataPoint<int>(-23.56281910,-46.66466190,-23.56686700,-46.67947800)

          };

        #endregion

        public static tipos tipo = tipos.euclidean;

        public int currentColor = 0;

        public Random r = new Random();

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Maximum = -46.28;
            chart1.ChartAreas[0].AxisY.Minimum = -47;

            chart1.ChartAreas[0].AxisX.Maximum = -23.3;
            chart1.ChartAreas[0].AxisX.Minimum = -23.8;

            var dataPoints = new HashSet<DataPoint<int>>();

            var dataPointsCount = 00;

            currentColor = 0;

            //gera n datapoints (entregas)
            //for (var i = 0; i < dataPointsCount; i++)
            //{
            //    dataPoints.Add(new DataPoint<int>(i, (r.NextDouble() * 360) - 180, (r.NextDouble() * 360) - 180));
            //}

            #region datapoints
            dataPoints.Add(new DataPoint<int>(1, -23.63073700, -46.76284400));
            dataPoints.Add(new DataPoint<int>(2, -23.47246600, -46.69145700));
            dataPoints.Add(new DataPoint<int>(3, -23.65500100, -46.63606800));
            dataPoints.Add(new DataPoint<int>(4, -23.51356100, -46.47214400));
            dataPoints.Add(new DataPoint<int>(5, -23.54063600, -46.50772000));
            dataPoints.Add(new DataPoint<int>(6, -23.60148400, -46.67020800));
            dataPoints.Add(new DataPoint<int>(7, -23.69411200, -46.50984100));
            dataPoints.Add(new DataPoint<int>(8, -23.71454600, -46.53431000));
            dataPoints.Add(new DataPoint<int>(9, -23.69517900, -46.49237500));
            dataPoints.Add(new DataPoint<int>(10, -23.54964100, -46.70074200));
            dataPoints.Add(new DataPoint<int>(11, -23.63106400, -46.75923500));
            dataPoints.Add(new DataPoint<int>(12, -23.59850700, -46.79617100));
            dataPoints.Add(new DataPoint<int>(13, -23.55167100, -46.77553600));
            dataPoints.Add(new DataPoint<int>(14, -23.61762400, -46.75971400));
            dataPoints.Add(new DataPoint<int>(15, -23.58806100, -46.74067200));
            dataPoints.Add(new DataPoint<int>(16, -23.63106400, -46.75923500));
            dataPoints.Add(new DataPoint<int>(17, -23.59850700, -46.79617100));
            dataPoints.Add(new DataPoint<int>(18, -23.61762400, -46.75971400));
            dataPoints.Add(new DataPoint<int>(19, -23.58421900, -46.70453400));
            dataPoints.Add(new DataPoint<int>(20, -23.55734400, -46.63531400));
            dataPoints.Add(new DataPoint<int>(21, -23.57086600, -46.53910000));
            dataPoints.Add(new DataPoint<int>(22, -23.46006300, -46.58104200));
            dataPoints.Add(new DataPoint<int>(23, -23.56266200, -46.64730900));
            dataPoints.Add(new DataPoint<int>(24, -23.59850700, -46.79617100));
            dataPoints.Add(new DataPoint<int>(25, -23.55167100, -46.77553600));
            dataPoints.Add(new DataPoint<int>(26, -23.61762400, -46.75971400));
            dataPoints.Add(new DataPoint<int>(27, -23.58421900, -46.70453400));
            dataPoints.Add(new DataPoint<int>(28, -23.51714500, -46.77178900));
            dataPoints.Add(new DataPoint<int>(29, -23.58806100, -46.74067200));
            dataPoints.Add(new DataPoint<int>(30, -23.54540300, -46.71281600));
            dataPoints.Add(new DataPoint<int>(31, -23.59938500, -46.67723000));
            dataPoints.Add(new DataPoint<int>(32, -23.53176900, -46.73454700));
            dataPoints.Add(new DataPoint<int>(33, -23.52588300, -46.44842800));
            dataPoints.Add(new DataPoint<int>(34, -23.56689100, -46.56070800));
            dataPoints.Add(new DataPoint<int>(35, -23.56245800, -46.58221300));
            dataPoints.Add(new DataPoint<int>(36, -23.57098900, -46.59345500));
            dataPoints.Add(new DataPoint<int>(37, -23.55827300, -46.58927300));
            dataPoints.Add(new DataPoint<int>(38, -23.54494800, -46.54692000));
            dataPoints.Add(new DataPoint<int>(39, -23.56508600, -46.64181700));
            dataPoints.Add(new DataPoint<int>(40, -23.53549100, -46.59959600));
            dataPoints.Add(new DataPoint<int>(41, -23.56126700, -46.63685900));
            dataPoints.Add(new DataPoint<int>(42, -23.49011300, -46.60249200));
            dataPoints.Add(new DataPoint<int>(43, -23.49372500, -46.70626100));
            dataPoints.Add(new DataPoint<int>(44, -23.45219200, -46.72911700));
            dataPoints.Add(new DataPoint<int>(45, -23.68508000, -46.46266700));
            dataPoints.Add(new DataPoint<int>(46, -23.40663400, -46.45492800));
            dataPoints.Add(new DataPoint<int>(47, -23.55130200, -46.54233600));
            dataPoints.Add(new DataPoint<int>(48, -23.52856500, -46.68533500));
            dataPoints.Add(new DataPoint<int>(49, -23.69260400, -46.57037500));
            dataPoints.Add(new DataPoint<int>(50, -23.68161500, -46.51300200));
            dataPoints.Add(new DataPoint<int>(51, -23.51844400, -46.58564600));
            dataPoints.Add(new DataPoint<int>(52, -23.48603700, -46.38723500));
            #endregion

            MelhorCluster(dataPoints.ToHashSet());

            //dataPointsCount = 60;           

            //dataPoints = new HashSet<DataPoint<int>>();

            ////gera n datapoints (entregas)
            //for (var i = 0; i < dataPointsCount; i++)
            //{
            //    dataPoints.Add(new DataPoint<int>(i, (r.NextDouble() * 200) - 100, (r.NextDouble() * 200) - 100));
            //}

            //MelhorCluster(dataPoints.ToHashSet());

        }

        private void MelhorCluster(HashSet<DataPoint<int>> dataPoints)
        {


            //inicializa classes do algoritmo
            var metric = new DissimilarityMetric<int>();
            var linkage = new AverageLinkage<DataPoint<int>>(metric);
            var algorithm = new AgglomerativeClusteringAlgorithm<DataPoint<int>>(linkage);

            //enquanto tiverem entregas pra clusterizar
            while (dataPoints.Any())
            {
                //clusteriza
                var clusteringResult = algorithm.GetClustering(dataPoints);

                //printa a clusterização
                clusteringResult.Select(x =>
                {
                    Console.WriteLine(x);

                    return 0;

                }).ToArray();

                //maximo de itens por cluster
                var MAX_ITEMS = 7;

                //vai ser feito uma força bruta no número minimo de itens, começando igual ao MAX_ITEMS e decrementando até 1 (uma entrega)
                var minItems = MAX_ITEMS;

                //Variavel de retorno da operação
                Cluster<DataPoint<int>> bestCluster = null;

                //força bruta
                while (minItems > 0)
                {
                    //vai percorrendo a lista de clusters do ultimo ao primeiro
                    for (var i = clusteringResult.Count() - 1; i >= 0; i--)
                    {
                        //ordenando decrescente pela quantidade de entregas pega o primeiro q tem a mesma quantidade ou menos q o MAX_ITEMS
                        bestCluster = clusteringResult[i].
                            OrderByDescending(x => x.Count()).
                            FirstOrDefault(y => y.Count() <= MAX_ITEMS);

                        //se a quantidade de entregas nesse cluster for igual ao minimo q estamos decrescendo finaliza o processo
                        if (bestCluster?.Count() == minItems)
                            break;
                    }

                    //como são dois loops, verifica de novo e repete o break
                    if (bestCluster?.Count() == minItems)
                        break;

                    //decresce o minItens pra tentar de novo
                    minItems--;
                }

                //resultado dessa iteração
                Console.WriteLine(bestCluster);

                var c = Color.FromArgb(200, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));

                chart1.Series.Add("series" + currentColor.ToString());

                chart1.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                bestCluster.Select(x =>
                {

                    chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
                    {
                        XValue = x.DestinoLatitude,
                        YValues = new double[] { x.DestinoLongitude },
                        // MarkerColor = c,
                        //Label = tipo.ToString() + " "+ currentColor.ToString() + " " + x.id.ToString(),
                        MarkerSize = 10
                    });

                    return false;
                }).ToArray();

                Application.DoEvents();

                // Thread.Sleep(2000);

                currentColor++;

                //remove as entregas já clusterizadas
                dataPoints.RemoveWhere(x => bestCluster.Any(y => y.Item == x.Item));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipo = tipos.euclidean;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipo = tipos.geodesic;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tipo = tipos.angularEuclidean;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PlotarPedidos(false, false);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PlotarPedidos(true, false);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            PlotarPedidos(false, true);
        }

        int kk = 0;

        private void PlotarPedidos(bool apenasProximos, bool apenasDistantes)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = -46.4;
            chart1.ChartAreas[0].AxisX.Minimum = -46.9;

            chart1.ChartAreas[0].AxisY.Maximum = -23.3;
            chart1.ChartAreas[0].AxisY.Minimum = -23.8;

            //File.WriteAllText("log.txt", $"ROTA 1;" +
            //               $"Rota 1 km;" +
            //               $"ROTA 2;" +
            //               $"DeslocamentoProprio;" +
            //               $"DeslocamentoExtra;" +
            //               $"Ganhos km;" +
            //               $"DistanciaOrigem;" +
            //               $"DistanciaAngular;" +
            //               $"DistanciaAngularAteOrigem;" +
            //               $"DistanciaConvergencia;" +
            //               $"DistanciaTotal;" +
            //               $"Rota 1 mapa;" +
            //               $"Rota 2 mapa;" +
            //               $"Rota completa mapa\n");

            if (!data[0].Casos.Any())

                for (var i = 0; i < data.Length; i++)
                {
                    var usuarioRota = data[i];

                    var usuarioLocation = new Coordinates((decimal)usuarioRota.InicioLatitude, (decimal)usuarioRota.InicioLongitude);

                    var usuarioDestino = new Coordinates((decimal)usuarioRota.DestinoLatitude, (decimal)usuarioRota.DestinoLongitude);

                    usuarioRota.DeslocamentoProprio = (decimal)new DataPoint<int>
                    {
                        DestinoLatitude = usuarioRota.InicioLatitude,
                        DestinoLongitude = usuarioRota.InicioLongitude
                    }.Euclidean(new DataPoint<int>
                    {
                        DestinoLatitude = usuarioRota.DestinoLatitude,
                        DestinoLongitude = usuarioRota.DestinoLongitude
                    });

                    for (var j = 0; j < data.Length; j++)
                    {
                        var pedidoRota = data[j];

                        usuarioRota.Item = i;



                        Coordinates segundoInicio = new Coordinates((decimal)pedidoRota.InicioLatitude, (decimal)pedidoRota.InicioLongitude);

                        Coordinates segundoDestino = new Coordinates((decimal)pedidoRota.DestinoLatitude, (decimal)pedidoRota.DestinoLongitude);


                        var degree_to_distance = 0.22m;

                        var max_distance = 150m * degree_to_distance;

                        if (i == 216 && j == 71)
                        {

                        }

                        var DistanciaOrigem = (decimal)LineToPointDistance2D(new double[] { usuarioRota.InicioLatitude, usuarioRota.InicioLongitude },
                            new double[] { usuarioRota.DestinoLatitude, usuarioRota.DestinoLongitude },
                            new double[] { pedidoRota.InicioLatitude, pedidoRota.InicioLongitude }, true);

                        var DistanciaOrigemDestino = (decimal)new DataPoint<int>
                        {
                            DestinoLatitude = usuarioRota.DestinoLatitude,
                            DestinoLongitude = usuarioRota.DestinoLongitude
                        }.Euclidean(new DataPoint<int>
                        {
                            DestinoLatitude = pedidoRota.InicioLatitude,
                            DestinoLongitude = pedidoRota.InicioLongitude
                        });



                        var DistanciaDestino = (decimal)LineToPointDistance2D(new double[] { usuarioRota.InicioLatitude, usuarioRota.InicioLongitude },
                            new double[] { usuarioRota.DestinoLatitude, usuarioRota.DestinoLongitude },
                            new double[] { pedidoRota.DestinoLatitude, pedidoRota.DestinoLongitude }, true);

                        //DistanciaOrigem = (decimal)Distance(new double[] { usuarioRota.InicioLatitude, usuarioRota.InicioLongitude },
                        //    new double[] { usuarioRota.DestinoLatitude, usuarioRota.DestinoLongitude },
                        //    new double[] { pedidoRota.InicioLatitude, pedidoRota.InicioLongitude });

                        var DistanciaAngularAteOrigem = 0M;

                        if (usuarioRota.InicioLatitude != pedidoRota.InicioLatitude ||
                             usuarioRota.InicioLongitude != pedidoRota.InicioLongitude)
                        {

                            DistanciaAngularAteOrigem = DistanciaOrigem > max_distance * degree_to_distance ?
                                max_distance * degree_to_distance :
                                (decimal)usuarioRota.AngularEuclidean(
                                    new DataPoint<int>()
                                    {
                                        InicioLatitude = usuarioRota.InicioLatitude,
                                        InicioLongitude = usuarioRota.InicioLongitude,
                                        DestinoLatitude = pedidoRota.InicioLatitude,
                                        DestinoLongitude = pedidoRota.InicioLongitude,
                                    }) * degree_to_distance;
                        }

                        var DistanciaAngular = DistanciaOrigem > max_distance * degree_to_distance ?
                           max_distance * degree_to_distance :
                           (decimal)usuarioRota.AngularEuclidean(pedidoRota) * degree_to_distance;

                        var DistanciaConvergencia = DistanciaAngularAteOrigem > max_distance * degree_to_distance ?
                            max_distance * degree_to_distance :
                            GetConvervencia(usuarioLocation, usuarioDestino, segundoInicio, segundoDestino);

                        var DeslocamentoExtra = DistanciaOrigem;

                        //Menor distancia entre segunda coleta e primeira rota não é no ponto final da primeira rota
                        // if (DistanciaOrigem != DistanciaOrigemDestino)
                        {
                            DeslocamentoExtra += DistanciaDestino;
                        }


                        usuarioRota.Casos.Add(pedidoRota, new Distancias { DeslocamentoExtra = (decimal)DeslocamentoExtra, DistanciaOrigem = (decimal)DistanciaOrigem, DistanciaAngular = (decimal)DistanciaAngular, DistanciaConvergencia = (decimal)DistanciaConvergencia, DistanciaAngularAteOrigem = (decimal)DistanciaAngularAteOrigem });

                       // continue;

                        //pedidoRota.Casos.Add(usuarioRota, new Distancias { DistanciaOrigem = (decimal)DistanciaOrigem, DistanciaConvergencia = (decimal)DistanciaConvergencia, DistanciaAngular = (decimal)DistanciaAngular });

                        if (i == j || usuarioRota.DeslocamentoProprio > 100 || pedidoRota.DeslocamentoProprio > 100 || usuarioRota.Casos[pedidoRota].DeslocamentoExtra > 100)
                            continue;

                        var t = usuarioRota.Casos[pedidoRota];

                        var imprimirMapas =
                            (pedidoRota.DeslocamentoProprio - usuarioRota.Casos[pedidoRota].DeslocamentoExtra > 10) ||

                            !(
                            //t.DistanciaConvergencia > decimal.Parse(txtDistanciaConvergencia.Text) ||
                            DistanciaAngularAteOrigem > decimal.Parse(txtDistanciaAngularOrigem.Text) ||
                            DistanciaOrigem > decimal.Parse(txtDistanciaOrigem.Text) ||
                            DistanciaAngular > decimal.Parse(txtDisntanciaAngularRetas.Text));

                        //File.AppendAllText("log.txt", $"{usuarioRota.Item};" +
                        //    $"{usuarioRota.DeslocamentoProprio:n2};" +
                        //    $"{pedidoRota.Item};" +
                        //    $"{pedidoRota.DeslocamentoProprio:n2};" +
                        //    $"{usuarioRota.Casos[pedidoRota].DeslocamentoExtra:n2};" +
                        //    $"{(pedidoRota.DeslocamentoProprio - usuarioRota.Casos[pedidoRota].DeslocamentoExtra):n2};" +
                        //    $"{usuarioRota.Casos[pedidoRota].DistanciaOrigem:n2};" +
                        //    $"{usuarioRota.Casos[pedidoRota].DistanciaAngular:n2};" +
                        //    $"{usuarioRota.Casos[pedidoRota].DistanciaAngularAteOrigem:n2};" +
                        //    $"{usuarioRota.Casos[pedidoRota].DistanciaConvergencia:n2};" +
                        //    $"{usuarioRota.Casos[pedidoRota].DistanciaTotal:n2};" +
                        //    (!imprimirMapas ? ";" : $"www.google.com.br/maps/dir/{usuarioRota.InicioLatitude},{usuarioRota.InicioLongitude}/{usuarioRota.DestinoLatitude},{usuarioRota.DestinoLongitude};") +
                        //    (!imprimirMapas ? ";" : $"www.google.com.br/maps/dir/{pedidoRota.InicioLatitude},{pedidoRota.InicioLongitude}/{pedidoRota.DestinoLatitude},{pedidoRota.DestinoLongitude};") +
                        //    (!imprimirMapas ? "\n" : $"www.google.com.br/maps/dir/{usuarioRota.InicioLatitude},{usuarioRota.InicioLongitude}/{usuarioRota.DestinoLatitude},{usuarioRota.DestinoLongitude}/{pedidoRota.InicioLatitude},{pedidoRota.InicioLongitude}/{pedidoRota.DestinoLatitude},{pedidoRota.DestinoLongitude}\n"));
                    }
                }




            var t1 = data[kk];

            var count = 0;

            var jj = 0;

            foreach (var t in t1.Casos.OrderBy(x => (x.Value.DeslocamentoExtra - x.Key.DeslocamentoProprio) * (apenasDistantes ? 1 : -1)))
            {
                if (apenasProximos &&
                    (t.Value.DistanciaConvergencia > decimal.Parse(txtDistanciaConvergencia.Text) ||
                    t.Value.DistanciaAngularAteOrigem > decimal.Parse(txtDistanciaAngularOrigem.Text) ||
                    t.Value.DistanciaOrigem > decimal.Parse(txtDistanciaOrigem.Text) ||
                    t.Value.DistanciaAngular > decimal.Parse(txtDisntanciaAngularRetas.Text)))
                    continue;

                if (apenasProximos &&
                    t.Value.DeslocamentoExtra > t.Key.DeslocamentoProprio)
                {
                    continue;
                }

                if (apenasDistantes && t.Value.DistanciaConvergencia < .05M)
                    continue;

                //if (jj++ > 15)
                //    continue;

                chart1.Series.Add($"caso {t.Key.Item}: [D:{t.Value.DeslocamentoExtra:n2}] [Dp:{t.Key.DeslocamentoProprio:n2}] [T:{t.Value.DistanciaTotal:n2}] [O:{t.Value.DistanciaOrigem:n2}] [A:{t.Value.DistanciaAngular:n2}] [AO:{t.Value.DistanciaAngularAteOrigem:n2}] [C:{t.Value.DistanciaConvergencia:n2}]");

                chart1.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                chart1.Series.Last().Color = GetColor(100, 0, 7, (int)t.Value.DistanciaTotal);

                chart1.Series.Last().BorderWidth = 5;

                chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
                {
                    XValue = (double)t.Key.InicioLongitude,
                    YValues = new double[] { (double)t.Key.InicioLatitude },
                    MarkerColor = GetColor(100, -7, 300, (int)t.Key.Item),
                    MarkerSize = t.Value.DistanciaTotal < 7 ? 10 : 5,
                    Label = t.Key.Item.ToString()
                });

                chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
                {
                    XValue = (double)t.Key.DestinoLongitude,
                    YValues = new double[] { (double)t.Key.DestinoLatitude },
                    MarkerColor = GetColor(100, -7, 300, (int)t.Key.Item),
                    MarkerSize = t.Value.DistanciaTotal < 7 ? 2 : 1
                });

                chart1.Series.Add($"_caso {t.Key.Item}a: [D:{t.Value.DeslocamentoExtra:n2}] [Dp:{t.Key.DeslocamentoProprio:n2}] [T:{t.Value.DistanciaTotal:n2}] [O:{t.Value.DistanciaOrigem:n2}] [A:{t.Value.DistanciaAngular:n2}] [AO:{t.Value.DistanciaAngularAteOrigem:n2}] [C:{t.Value.DistanciaConvergencia:n2}]");

                chart1.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;


                chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
                {
                    XValue = (double)t.Key.InicioLongitude,
                    YValues = new double[] { (double)t.Key.InicioLatitude },
                    MarkerColor = GetColor(100, -7, 300, (int)t.Key.Item),
                    MarkerSize = t.Value.DistanciaConvergencia < 7 ? 10 : 5,
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                });

                chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
                {
                    XValue = (double)t.Key.DestinoLongitude,
                    YValues = new double[] { (double)t.Key.DestinoLatitude },
                    MarkerColor = GetColor(100, -7, 300, (int)t.Key.Item),
                    MarkerSize = t.Value.DistanciaTotal < 7 ? 2 : 1,
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                });

            }

            chart1.Series.Add("base" + kk.ToString());

            chart1.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series.Last().Color = Color.FromArgb(255, 19, 186, 148);

            chart1.Series.Last().BorderWidth = 5;

            chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
            {
                XValue = (double)t1.InicioLongitude,
                YValues = new double[] { (double)t1.InicioLatitude },
                MarkerColor = Color.FromArgb(255, 19, 186, 148),
                MarkerSize = 10
            });

            chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
            {
                XValue = (double)t1.DestinoLongitude,
                YValues = new double[] { (double)t1.DestinoLatitude },
                MarkerColor = Color.FromArgb(255, 19, 186, 148),
                MarkerSize = 2
            });

            chart1.Series.Add("base_" + kk.ToString());

            chart1.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
            {
                XValue = (double)t1.InicioLongitude,
                YValues = new double[] { (double)t1.InicioLatitude },
                MarkerColor = Color.FromArgb(255, 19, 186, 148),
                MarkerSize = 10,
                MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle,
                Label = "Pedido Em Andamento"
            });

            chart1.Series.Last().Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint
            {
                XValue = (double)t1.DestinoLongitude,
                YValues = new double[] { (double)t1.DestinoLatitude },
                MarkerColor = Color.FromArgb(255, 19, 186, 148),
                MarkerSize = 2,
                MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
            });
        }

        static decimal orientation(Coordinates p, Coordinates q, Coordinates r)
        {
            decimal val = (q.Longitude - p.Longitude) * (r.Latitude - q.Latitude) -
                    (q.Latitude - p.Latitude) * (r.Longitude - q.Longitude);

            if (val == 0) return 0; // colinear 

            return (val > 0) ? 1 : 2; // clock or counterclock wise 
        }

        public double Distance(double[] a, double[] b, double[] c)
        {
            // normalize points
            var cn = new double[] { c[0] - a[0], c[1] - a[1] };
            var bn = new double[] { b[0] - a[0], b[1] - a[1] };

            double angle = Math.Atan2(bn[1], bn[0]) - Math.Atan2(cn[1], cn[0]);
            double abLength = Math.Sqrt(bn[0] * bn[0] + bn[1] * bn[1]);

            return Math.Sin(angle) * abLength;
        }

        //Compute the dot product AB . BC
        private double DotProduct(double[] pointA, double[] pointB, double[] pointC)
        {
            double[] AB = new double[2];
            double[] BC = new double[2];
            AB[0] = pointB[0] - pointA[0];
            AB[1] = pointB[1] - pointA[1];
            BC[0] = pointC[0] - pointB[0];
            BC[1] = pointC[1] - pointB[1];
            double dot = AB[0] * BC[0] + AB[1] * BC[1];

            return dot;
        }

        //Compute the cross product AB x AC
        private double CrossProduct(double[] pointA, double[] pointB, double[] pointC)
        {
            double[] AB = new double[2];
            double[] AC = new double[2];
            AB[0] = pointB[0] - pointA[0];
            AB[1] = pointB[1] - pointA[1];
            AC[0] = pointC[0] - pointA[0];
            AC[1] = pointC[1] - pointA[1];
            double cross = AB[0] * AC[1] - AB[1] * AC[0];

            return cross;
        }

        //Compute the distance from A to B
        double Distance(double[] pointA, double[] pointB)
        {
            double d1 = pointA[0] - pointB[0];
            double d2 = pointA[1] - pointB[1];

            return Math.Sqrt(d1 * d1 + d2 * d2);
        }

        //Compute the distance from AB to C
        //if isSegment is true, AB is a segment, not a line.
        double LineToPointDistance2D(double[] pointA, double[] pointB, double[] pointC,
            bool isSegment)
        {
            double dist = CrossProduct(pointA, pointB, pointC) / Distance(pointA, pointB);
            if (isSegment)
            {
                double dot1 = DotProduct(pointA, pointB, pointC);
                if (dot1 > 0)
                    return Distance(pointB, pointC) * 100;

                double dot2 = DotProduct(pointB, pointA, pointC);
                if (dot2 > 0)
                    return Distance(pointA, pointC) * 100;
            }
            return Math.Abs(dist) * 100;
        }

        static decimal GetConvervencia(Coordinates primeiroInicio, Coordinates primeiroDestino, Coordinates segundoInicio, Coordinates segundoDestino)
        {
            var degrees_to_distance = 0.2266666666666667M;

            var max_distance = 60;

            //Encontrar as equações das semiretas
            decimal a1 = (primeiroDestino.Longitude - primeiroInicio.Longitude) / (primeiroDestino.Latitude - primeiroInicio.Latitude);
            decimal b1 = (primeiroInicio.Longitude - a1 * primeiroInicio.Latitude);

            decimal a2 = (segundoDestino.Longitude - segundoInicio.Longitude) / (segundoDestino.Latitude - segundoInicio.Latitude);
            decimal b2 = (segundoInicio.Longitude - a2 * segundoInicio.Latitude);

            //Verificar convergencia
            //Semireta 1 é a reta de referencia

            decimal alpha1 = (decimal)Math.Atan((double)a1);
            decimal alpha2 = (decimal)Math.Atan((double)a2);

            if (alpha1 < 0) alpha1 = (1.57079632679M + alpha1 * (-1));
            if (alpha2 < 0) alpha2 = (1.57079632679M + alpha2 * (-1));

            //Verifica a orientação
            var o1 = orientation(primeiroInicio, primeiroDestino, segundoInicio);
            var o2 = orientation(primeiroInicio, primeiroDestino, segundoDestino);
            var o3 = orientation(segundoInicio, segundoDestino, primeiroInicio);
            var o4 = orientation(segundoInicio, segundoDestino, primeiroDestino);

            if (o1 != o2 && o3 != o4)
            {
                //Se cruza e diverge
                Console.WriteLine($"Se cruza e diverge {((alpha2 - alpha1) * (180M / (decimal)Math.PI)).ToString("n2")}");

                return Math.Min(max_distance, Math.Abs((alpha2 - alpha1) * (180M / (decimal)Math.PI))) * degrees_to_distance;
            }
            else
            {
                //Não se cruza
                if (primeiroInicio.Latitude > segundoInicio.Latitude)
                {
                    if ((alpha2 - alpha1) > 0)
                    {
                        Console.WriteLine($"Não se cruza e diverge {((alpha2 - alpha1) * (180M / (decimal)Math.PI)).ToString("n2")}");

                        return Math.Min(max_distance, Math.Abs((alpha2 - alpha1) * (180M / (decimal)Math.PI))) * degrees_to_distance;
                    }
                    else if ((alpha2 - alpha1) < 0)
                    {
                        Console.WriteLine($"Não se cruza e converge {((alpha2 - alpha1) * (180M / (decimal)Math.PI)).ToString("n2")}");

                        return Math.Min(max_distance / 4, Math.Abs((alpha2 - alpha1) * (180M / (decimal)Math.PI))) * degrees_to_distance * -1;
                    }
                }
                else if (primeiroInicio.Latitude < segundoInicio.Latitude)
                {
                    if ((alpha2 - alpha1) > 0)
                    {
                        Console.WriteLine($"Não se cruza e converge {((alpha2 - alpha1) * (180M / (decimal)Math.PI)).ToString("n2")}");

                        return Math.Min(max_distance / 4, Math.Abs((alpha2 - alpha1) * (180M / (decimal)Math.PI))) * degrees_to_distance * -1;

                    }
                    else if ((alpha2 - alpha1) < 0)
                    {
                        Console.WriteLine($"Não se cruza e diverge {((alpha2 - alpha1) * (180M / (decimal)Math.PI)).ToString("n2")}");

                        return Math.Min(max_distance, Math.Abs((alpha2 - alpha1) * (180M / (decimal)Math.PI))) * degrees_to_distance;
                    }
                }
            }

            return max_distance * degrees_to_distance;

            if ((alpha2 - alpha1) == 0) //São paralelas. Isso é uma situação muito dificil de se acontecer no mundo real        \\
            {
                Console.WriteLine($"São Paralelas {((alpha2 - alpha1) * (180M / (decimal)Math.PI)).ToString("n2")}");


            }
        }

        Color GetColor(int alpha, Int32 rangeStart /*Complete Red*/, Int32 rangeEnd /*Complete Green*/, Int32 actualValue)
        {
            if (rangeStart >= rangeEnd) return Color.Black;

            Int32 max = rangeEnd - rangeStart; // make the scale start from 0
            Int32 value = actualValue - rangeStart; // adjust the value accordingly

            Int32 green = (255 * value) / max; // calculate green (the closer the value is to max, the greener it gets)
            Int32 red = 255 - green; // set red as inverse of green

            return Color.FromArgb(alpha, (Byte)red, (Byte)green, (Byte)0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kk = new Random().Next(0, data.Length);
        }
    }

    public class DissimilarityMetric<T> : IDissimilarityMetric<DataPoint<T>>
    {
        public double Calculate(DataPoint<T> instance1, DataPoint<T> instance2)
        {
            return instance1.CompareTo(instance2);
        }
    }

    public class DataPoint<T> : IComparable<DataPoint<T>>
    {
        public T Item { get; set; }

        public double DestinoLatitude { get; set; }

        public double DestinoLongitude { get; set; }

        public double InicioLatitude { get; set; }

        public double InicioLongitude { get; set; }

        public decimal DeslocamentoProprio { get; set; }

        public Dictionary<DataPoint<T>, Distancias> Casos { get; internal set; } = new Dictionary<DataPoint<T>, Distancias>();

        public DataPoint(T id, double inicioLatitude, double inicioLongitude, double destinoLatitude, double destinoLongitude)
        {
            this.Item = id;

            this.DestinoLatitude = destinoLatitude;

            this.DestinoLongitude = destinoLongitude;

            this.InicioLatitude = inicioLatitude;

            this.InicioLongitude = inicioLongitude;
        }


        public DataPoint(T id, double lat, double lon) : this(id, lat, lon, -23.55, -46.6)
        {
        }

        public DataPoint(double inicioLatitude, double inicioLongitude, double destinoLatitude, double destinoLongitude) : this(default(T), inicioLatitude, inicioLongitude, destinoLatitude, destinoLongitude)
        {
        }

        public DataPoint()
        {

        }

        public int CompareTo(DataPoint<T> other)
        {
            if (Form1.tipo == tipos.euclidean)
                return (int)this.Euclidean(other);

            if (Form1.tipo == tipos.geodesic)
                return (int)this.Geodesic(other);

            return (int)this.AngularEuclidean(other);
        }

        public override string ToString()
        {
            return Item.ToString();
        }

        public double Euclidean(DataPoint<T> other)
        {
            return Math.Sqrt(Math.Pow(this.DestinoLatitude - other.DestinoLatitude, 2) + Math.Pow(this.DestinoLongitude - other.DestinoLongitude, 2)) * 100;
        }

        public double Geodesic(DataPoint<T> other)
        {
            return new GeoCoordinate(this.DestinoLatitude, this.DestinoLongitude).GetDistanceTo(new GeoCoordinate(other.DestinoLatitude, other.DestinoLongitude));
        }

        public double AngularEuclidean(DataPoint<T> other)
        {
            var deltaX = this.DestinoLatitude - this.InicioLatitude;
            var deltaY = this.DestinoLongitude - this.InicioLongitude;
            var rad = Math.Atan2(deltaY, deltaX);

            var deltaX2 = other.DestinoLatitude - other.InicioLatitude;
            var deltaY2 = other.DestinoLongitude - other.InicioLongitude;
            var rad2 = Math.Atan2(deltaY2, deltaX2);

            var pi2 = Math.PI * 2;

            var dx = Math.Abs(rad - rad2);
            if (dx > pi2 / 2)
                dx = pi2 - dx;

            // Console.WriteLine(this.id + " " +other.id + ": " + dx.ToString() +  "---" + ((rad - rad2) * (180 / Math.PI)).ToString() + "  " + (rad - rad2).ToString());

            return dx * (180 / Math.PI);
        }


    }



    public class Coordinates
    {
        public decimal Latitude;
        public decimal Longitude;

        public Coordinates(decimal latitude, decimal longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    };

    public class Distancias
    {
        public decimal DistanciaOrigem { get; set; }

        public decimal DistanciaAngularAteOrigem { get; set; }

        public decimal DistanciaAngular { get; set; }

        public decimal DeslocamentoExtra { get; set; }

        public decimal DistanciaConvergencia { get; set; }

        public decimal DistanciaTotal
        {
            get => (decimal)Math.Sqrt((double)(DistanciaOrigem * DistanciaOrigem + DistanciaAngular * DistanciaAngular + DistanciaAngularAteOrigem * DistanciaAngularAteOrigem)) + DistanciaConvergencia;
        }
    }

}
