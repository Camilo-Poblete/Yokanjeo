<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Yokanjeo.Home.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>YOKANJEO</title>
    <link href="css/Home.css" rel="stylesheet" />
   <%-- <link href="css/style.css" rel="stylesheet" />--%>
     <link rel="icon" type="imagen" href="../Images/Icono.jpg"   />
   
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css">
</head>
<body>
    
    <header>
       <div class="nav container">
           <figure>
                <a href="Home.aspx" class="logotipo">
        <img src="../Images/YOKANJEO.JPG" width="166px" height="60px" alt="">
    </a>
               
           </figure>
         
           <input type="checkbox" name="name" id="menu" />
           <label for="menu" <i class='bx bx-menu'id="menu-icon" ></i></label>

           <ul class="navbar">
               <li><a href="#home">Inicio</a></li>
                <li><a href="#about">Acerca de</a></li>
                <li><a href="#sales">Ventas</a></li>
                <li><a href="#properties">Propiedades</a></li>
                <li><a href="../Algunos/Nuestras_propiedades.aspx">Algunos proyectos</a></li>
           </ul>
           <a href="../Page/Iniciar_sesion.aspx" class="btn">Iniciar Sesion</a>
           
       </div>
    </header>  
    
    <section class="home container" id="home">
        <div class="home-text">
            <h1> Encuentra tu siguiente <br>Lugar perfecto para<br>Vivivr.</h1>
            <a href="../Page/Registro.aspx" class="btn">Registrate</a>
        </div>
    </section>

    <!-- About -->

    <section class="about container" id="about">
        <div class="about-img">
            <img src="../Images/about.jpg" alt="" >
            

        </div>

        <div class="about-text">
           <br />
            <span>Acerca de</span>
            
            <h2>Nosotros proporcionamos las mejores <br >Propiedades para ti !</h2>
            <br />
            <h5>YOKANJEO fue fundada el año 2022, con la finalidad de ofrecer servicios de asesoría integral en la gestión y desarrollo de proyectos inmobiliarios de distinta índole.
         Sus socios Mauricio Núñez Varela y Felipe Apparcel Knoop, ambos reúnen más de 35 años de experiencia acumulado en el rubro inmobiliario y construcción, y que, junto al equipo ejecutivo de la empresa, son el principal activo que permite ofrecer óptimos resultados en sus proyectos.
         Desde sus inicios a la fecha, </h5>
            <br />
            <h5>la empresa ha crecido sostenida y orgánicamente, manteniendo actualmente una cartera de proyectos que suman más de 90.000 mt2 de construcción, y cuyas ventas superan las UF 3.200.000.</h5>
             <br />
        <%--    <a href="#" class="btn"> Learn more</a>--%>
        </div>


    </section>

      <!-- Sales -->

    <section class="sales container" id="sales">
          <!-- Box 1 -->
        <div class="box">
            <i class="bx bx-user"></i>
            <h3>Haz realidad tu sueño </h3>
            <p>Lorem ipsum, dolor sit amet consectetur adipiscing .iusto debitis ducimus ne </p>
        </div>
    


          <!-- Box 2 -->
        <div class="box">
            <i class="bx bx-desktop"></i>
            <h3>Comienza tus publicaciones de Propiedades o Ventas</h3>
            <p>Lorem ipsum, dolor sit amet consectetur adipiscing .iusto debitis ducimus ne </p>
        </div>
   

     <!-- Box 3 -->
      <div class="box">
            <i class="bx bx-home-alt"></i>
            <h3>Disfruta de tu nuevo hogar</h3>
            <p>Lorem ipsum, dolor sit amet consectetur adipiscing .iusto debitis ducimus ne </p>
        </div>

        </section>

     <!-- Properties -->

    <section class="properties container" id="properties">
        <div class="heading">
            <span>Recent</span>
            <div class="propiedad-text">
              <h2>Our Featured</h2>
            <p>Lorem ipsum, dolor sit amet consectetur adipiscing <br />
                .iusto debitis ducimus ne </p>
            </div>
           
        </div>
        <div class="properties-container container">
            <div class="box">

                <img src="../Images/casa6.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>Santiago,Las condes</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>


                </div>
            </div>

             <div class="box">

                <img src="../Images/cas10.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>3</span></i>
                        <i class="bx bx-bath"><span>3</span></i>
                    </div>


                </div>
            </div>



             <div class="box">

                <img src="../Images/pexels-expect-best-323780.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>


                </div>
            </div>



             <div class="box">

                <img src="../Images/pexels-thgusstavo-santana-2102587 (2).png" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>


                </div>
            </div>



             <div class="box">

                <img src="../Images/casa6.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>


                </div>
            </div>


             <div class="box">

                <img src="../Images/casa6.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>


                </div>
            </div>



            
             <div class="box">

                <img src="../Images/casa6.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>


                </div>
            </div>


            
             <div class="box">

                <img src="../Images/pexels-expect-best-323780.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>


                </div>
            </div>



             <div class="box">

                <img src="../Images/Diseño-de-casa-de-campo-moderna1.jpg" alt="" />
                <h3>UF7</h3>
                <div class="content">
                    <div class="text">
                         <h3>The palace</h3>
                        <p>London,UK</p>
                    </div>
                    <div class="icon">
                        <i class="bx bx-bed"><span>5</span></i>
                        <i class="bx bx-bath"><span>2</span></i>
                    </div>

                </div>
            </div>




        </div>



    </section>   

    <!-- NewsLetter -->

    <section class="newsletter container">
        <h2>Have Question in mind? <br> Let us help you</h2>
        <form action="">
            <input type="email" name="name" id="email-box" placeholder="Yokanjeo@hotmail.com" required/>
            <input type="submit" value="Send" class="btn"/>

        </form>


    </section>

    <!-- Footer-->

    <section class="footer">
        <div class="footer-container container">
            <h2>R. State</h2>
            <div class="footer-box">
                <h3>Quick Links</h3>
                <a href="#">Agency</a>
                <a href="#">Building</a>
                <a href="#">Rates</a>
            </div>

              <div class="footer-box">
                <h3>Locations</h3>
                <a href="#">Birmingham</a>
                <a href="#">London</a>
                <a href="#">New York</a>
            </div>

             <div class="footer-box">
                <h3>Contact</h3>
                <a href="#">+ 55 9 89645789</a>
                <a href="#">Yokanjeo@gmail.com</a>
                 <div class="social">
                     <a href="#"<i class="bx bxl-facebook"></i></a>
                     <a href="#"<i class="bx bxl-twitter"></i></a>
                      <a href="#"<i class="bx bxl-instagram"></i></a>
                 </div>
            </div>


        </div>
    </section>

    <div class="copyright">
        <p>&#169; YOKANJEO All Right reserved</p>
    </div>


  




    </form>
</body>
</html>
