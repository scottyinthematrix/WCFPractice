service被host在一个Console Application中，其配置信息从配置文件读取；
service采用了netTcp作为其endpoint协议类型，client也使用此相同协议与之通信；
为了让mex与tcp共用同一个端口（PortSharing - no why），mex终结点也使用了tcp终结点一样的bindingConfiguration；
代理类的生成使用的是http协议，通过在ServiceMetaData中指定好httpGetUrl；

如果不对mex终结点做特殊处理，它会和tcp终结点侦听同一个端口，一个未支持共享侦听的端口，从而引发socket异常：
There is already a listener on IP endpoint 0.0.0.0:808. This could happen if there is another application already listening on this endpoint or if you have multiple service endpoints in your service host with the same IP endpoint but with incompatible binding configurations.