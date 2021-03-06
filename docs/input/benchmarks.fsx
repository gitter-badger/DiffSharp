﻿
(**
Benchmarks
==========

The following tables present the running times of the operations in the library for a set of simple test cases. For descriptions of the differentiation operations, please refer to [API Overview](api-overview.html).

The values are normalized with respect to the running time of the original function corresponding to each column. Operations **diffn** and **diffn'** are used with $n=2$, for enabling comparisons with **diff2** and **diff2'**. The used functions are $ f(x) = (\sin \sqrt{x + 2}) ^ 3$ for the scalar-to-scalar case, $ f(x,y,z) = (x\;\sqrt{y + z}\;\log z) ^ y $ for the vector-to-scalar case, and $f(x,y,z) = (\sin{x ^ y}, \sqrt{y + 2}, \log{xz}) $ for the vector-to-vector case.

The running times are averaged over half a million calls to each operation, on a PC with an Intel Core i7-4510U 2.0 GHz CPU and 16 GB RAM, running Windows 8.1 and .NET Framework 4.5.1.

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg th{font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg .tg-gik2{font-size:10px;background-color:#ecf4ff;color:#000000;text-align:center}
.tg .tg-ieqq{font-size:10px;background-color:#e4ffb3;text-align:center}
.tg .tg-habg{font-weight:bold;font-size:10px;font-family:serif !important;}
.tg .tg-g4y3{font-size:10px;}
.tg .tg-x05y{font-size:10px;background-color:#ffffc7;text-align:center}
.tg .tg-8xte{font-size:10px;background-color:#ecf4ff;text-align:center}
</style>
<table class="tg">
  <tr>
    <th class="tg-g4y3"></th>
    <th class="tg-x05y">diff </th>
    <th class="tg-x05y">diff2 </th>
    <th class="tg-x05y">diffn </th>
    <th class="tg-ieqq">grad </th>
    <th class="tg-ieqq">gradv</th>
    <th class="tg-ieqq">hessian </th>
    <th class="tg-ieqq">hessianv</th>
    <th class="tg-ieqq">gradhessian </th>
    <th class="tg-ieqq">gradhessianv</th>
    <th class="tg-ieqq">laplacian </th>
    <th class="tg-gik2">jacobian </th>
    <th class="tg-8xte">jacobianv</th>
    <th class="tg-8xte">jacobianT</th>
    <th class="tg-8xte">jacobianTv</th>
  </tr>
  <tr>
    <td class="tg-habg">AD</td>
    <td class="tg-x05y">23.98</td>
    <td class="tg-x05y">24.38</td>
    <td class="tg-x05y">30.77</td>
    <td class="tg-ieqq">48.77</td>
    <td class="tg-ieqq">15.34</td>
    <td class="tg-ieqq">336.63</td>
    <td class="tg-ieqq">133.60</td>
    <td class="tg-ieqq">330.65</td>
    <td class="tg-ieqq">127.23</td>
    <td class="tg-ieqq">242.98</td>
    <td class="tg-8xte">57.94</td>
    <td class="tg-8xte">12.01</td>
    <td class="tg-8xte">65.83</td>
    <td class="tg-8xte">31.94</td>
  </tr>
  <tr>
    <td class="tg-habg">ADF</td>
    <td class="tg-x05y">10.42</td>
    <td class="tg-x05y">13.65</td>
    <td class="tg-x05y">19.77</td>
    <td class="tg-ieqq">28.73</td>
    <td class="tg-ieqq">8.54</td>
    <td class="tg-ieqq">260.84</td>
    <td class="tg-ieqq">78.80</td>
    <td class="tg-ieqq">252.27</td>
    <td class="tg-ieqq">80.72</td>
    <td class="tg-ieqq">197.76</td>
    <td class="tg-8xte">43.19</td>
    <td class="tg-8xte">8.31</td>
    <td class="tg-8xte">37.53</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">ADR</td>
    <td class="tg-x05y">27.94</td>
    <td class="tg-x05y">38.12</td>
    <td class="tg-x05y">53.43</td>
    <td class="tg-ieqq">25.81</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">261.93</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">254.12</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">229.83</td>
    <td class="tg-8xte">58.04</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">63.88</td>
    <td class="tg-8xte">20.56</td>
  </tr>
  <tr>
    <td class="tg-habg">SADF1</td>
    <td class="tg-x05y">3.13</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">11.75</td>
    <td class="tg-ieqq">3.47</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-gik2">26.55</td>
    <td class="tg-8xte">3.61</td>
    <td class="tg-8xte">19.49</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADF2</td>
    <td class="tg-x05y">4.46</td>
    <td class="tg-x05y">3.85</td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">13.62</td>
    <td class="tg-ieqq">4.32</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">13.79</td>
    <td class="tg-gik2">27.82</td>
    <td class="tg-8xte">4.40</td>
    <td class="tg-8xte">21.07</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADFG</td>
    <td class="tg-x05y">5.37</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">17.09</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-gik2">16.02</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">20.99</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADFGH</td>
    <td class="tg-x05y">36.49</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">135.78</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">108.99</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">110.28</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">113.43</td>
    <td class="tg-gik2">86.92</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">90.21</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADFN</td>
    <td class="tg-x05y">19.98</td>
    <td class="tg-x05y">46.94</td>
    <td class="tg-x05y">53.20</td>
    <td class="tg-ieqq">113.00</td>
    <td class="tg-ieqq">38.59</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">359.99</td>
    <td class="tg-8xte">99.18</td>
    <td class="tg-8xte">26.66</td>
    <td class="tg-8xte">88.39</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADR1</td>
    <td class="tg-x05y">10.27</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">9.71</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-gik2">25.39</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">30.06</td>
    <td class="tg-8xte">9.10</td>
  </tr>
  <tr>
    <td class="tg-habg">N</td>
    <td class="tg-x05y">2.12</td>
    <td class="tg-x05y">3.15</td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">17.81</td>
    <td class="tg-ieqq">10.82</td>
    <td class="tg-ieqq">102.87</td>
    <td class="tg-ieqq">38.59</td>
    <td class="tg-ieqq">100.53</td>
    <td class="tg-ieqq">52.04</td>
    <td class="tg-ieqq">101.01</td>
    <td class="tg-gik2">44.69</td>
    <td class="tg-8xte">11.93</td>
    <td class="tg-8xte">41.73</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">S (Compile)</td>
    <td class="tg-x05y">1.08M</td>
    <td class="tg-x05y">8.91M</td>
    <td class="tg-x05y">9.03M</td>
    <td class="tg-ieqq">5.69M</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">109.43M</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">116.81M</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">55.94M</td>
    <td class="tg-8xte">2.56M</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">2.55M</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">S (Use)</td>
    <td class="tg-x05y">1.40k</td>
    <td class="tg-x05y">368.08</td>
    <td class="tg-x05y">84.59</td>
    <td class="tg-ieqq">46.92k</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">205.64k</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">246.96k</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">101.52k</td>
    <td class="tg-8xte">25.87k</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">18.64k</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr style="visibility:hidden">
    <td class="tg-g4y3"></td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-g4y3"></td>
    <td class="tg-x05y">diff'</td>
    <td class="tg-x05y">diff2'</td>
    <td class="tg-x05y">diffn'</td>
    <td class="tg-ieqq">grad'</td>
    <td class="tg-ieqq">gradv'</td>
    <td class="tg-ieqq">hessian'</td>
    <td class="tg-ieqq">hessianv'</td>
    <td class="tg-ieqq">gradhessian'</td>
    <td class="tg-ieqq">gradhessianv'</td>
    <td class="tg-ieqq">laplacian'</td>
    <td class="tg-8xte">jacobian'</td>
    <td class="tg-8xte">jacobianv'</td>
    <td class="tg-8xte">jacobianT'</td>
    <td class="tg-8xte">jacobianTv'</td>
  </tr>
  <tr>
    <td class="tg-habg">AD</td>
    <td class="tg-x05y">8.13</td>
    <td class="tg-x05y">32.47</td>
    <td class="tg-x05y">27.54</td>
    <td class="tg-ieqq">40.74</td>
    <td class="tg-ieqq">15.36</td>
    <td class="tg-ieqq">341.78</td>
    <td class="tg-ieqq">126.67</td>
    <td class="tg-ieqq">334.03</td>
    <td class="tg-ieqq">126.72</td>
    <td class="tg-ieqq">241.42</td>
    <td class="tg-8xte">58.19</td>
    <td class="tg-8xte">12.37</td>
    <td class="tg-8xte">67.64</td>
    <td class="tg-8xte">31.89</td>
  </tr>
  <tr>
    <td class="tg-habg">ADF</td>
    <td class="tg-x05y">5.55</td>
    <td class="tg-x05y">19.44</td>
    <td class="tg-x05y">16.48</td>
    <td class="tg-ieqq">28.70</td>
    <td class="tg-ieqq">8.84</td>
    <td class="tg-ieqq">259.04</td>
    <td class="tg-ieqq">78.86</td>
    <td class="tg-ieqq">259.09</td>
    <td class="tg-ieqq">78.42</td>
    <td class="tg-ieqq">198.12</td>
    <td class="tg-8xte">43.46</td>
    <td class="tg-8xte">8.32</td>
    <td class="tg-8xte">38.83</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">ADR</td>
    <td class="tg-x05y">11.18</td>
    <td class="tg-x05y">50.42</td>
    <td class="tg-x05y">41.28</td>
    <td class="tg-ieqq">25.01</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">251.05</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">253.50</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">222.50</td>
    <td class="tg-8xte">58.65</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">65.45</td>
    <td class="tg-8xte">20.54</td>
  </tr>
  <tr>
    <td class="tg-habg">SADF1</td>
    <td class="tg-x05y">2.90</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">10.41</td>
    <td class="tg-ieqq">3.35</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-8xte">26.60</td>
    <td class="tg-8xte">3.95</td>
    <td class="tg-8xte">20.60</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADF2</td>
    <td class="tg-x05y">4.16</td>
    <td class="tg-x05y">4.30</td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">13.23</td>
    <td class="tg-ieqq">4.55</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">12.72</td>
    <td class="tg-8xte">27.45</td>
    <td class="tg-8xte">4.53</td>
    <td class="tg-8xte">22.14</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADFG</td>
    <td class="tg-x05y">4.08</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">9.21</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-8xte">15.74</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">21.39</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADFGH</td>
    <td class="tg-x05y">28.23</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">117.67</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">112.93</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">111.61</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">111.99</td>
    <td class="tg-8xte">85.94</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">90.42</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADFN</td>
    <td class="tg-x05y">19.03</td>
    <td class="tg-x05y">48.01</td>
    <td class="tg-x05y">46.26</td>
    <td class="tg-ieqq">114.36</td>
    <td class="tg-ieqq">42.24</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">338.16</td>
    <td class="tg-8xte">103.73</td>
    <td class="tg-8xte">27.91</td>
    <td class="tg-8xte">89.30</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">SADR1</td>
    <td class="tg-x05y">5.28</td>
    <td class="tg-x05y"></td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">9.21</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq"></td>
    <td class="tg-8xte">24.40</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">29.99</td>
    <td class="tg-8xte">8.26</td>
  </tr>
  <tr>
    <td class="tg-habg">N</td>
    <td class="tg-x05y">3.60</td>
    <td class="tg-x05y">4.71</td>
    <td class="tg-x05y"></td>
    <td class="tg-ieqq">14.38</td>
    <td class="tg-ieqq">12.51</td>
    <td class="tg-ieqq">99.69</td>
    <td class="tg-ieqq">38.51</td>
    <td class="tg-ieqq">100.27</td>
    <td class="tg-ieqq">51.68</td>
    <td class="tg-ieqq">99.07</td>
    <td class="tg-8xte">43.65</td>
    <td class="tg-8xte">13.10</td>
    <td class="tg-8xte">38.66</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">S (Compile)</td>
    <td class="tg-x05y">847.24k</td>
    <td class="tg-x05y">9.02M</td>
    <td class="tg-x05y">9.01M</td>
    <td class="tg-ieqq">5.70M</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">109.46M</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">115.17M</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">56.07M</td>
    <td class="tg-8xte">2.55M</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">2.55M</td>
    <td class="tg-8xte"></td>
  </tr>
  <tr>
    <td class="tg-habg">S (Use)</td>
    <td class="tg-x05y">200.05</td>
    <td class="tg-x05y">217.19</td>
    <td class="tg-x05y">217.76</td>
    <td class="tg-ieqq">41.94k</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">208.48k</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">244.39k</td>
    <td class="tg-ieqq"></td>
    <td class="tg-ieqq">116.57k</td>
    <td class="tg-8xte">25.14k</td>
    <td class="tg-8xte"></td>
    <td class="tg-8xte">23.69k</td>
    <td class="tg-8xte"></td>
  </tr>
</table>

<br>

Running Benchmarks on Your Machine
----------------------------------

If you would like to run the benchmarks on your own machine, you can use the **_DiffSharp Benchmarks_** command line tool distributed together with the latest release <a href="https://github.com/gbaydin/DiffSharp/releases">on GitHub</a>.

<div class="row">
    <div class="span6">
        <img src="img/benchmarks.png" alt="Chart" style="width:569px"/>
    </div>
</div>
*)

