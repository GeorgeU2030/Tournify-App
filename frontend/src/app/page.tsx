"use client"
import React from 'react'
import { Card, CardContent } from "@/components/ui/card"
import {
  Carousel,
  CarouselContent,
  CarouselItem,
  CarouselNext,
  CarouselPrevious,
} from "@/components/ui/carousel"
import Autoplay from "embla-carousel-autoplay"

export default function page() {

  const plugin = React.useRef(
    Autoplay({ delay: 2000, stopOnInteraction: true })
  )

  const imageUrls = [
    'https://cnnespanol.cnn.com/wp-content/uploads/2023/06/GettyImages-1258593002-e1686432159344.jpg?quality=100&strip=info',
    'https://e00-marca.uecdn.es/assets/multimedia/imagenes/2023/06/13/16866405740867.jpg',
    'https://s1.eestatic.com/2023/07/16/deportes/tenis/779432433_234752227_1706x960.jpg',
    'https://www.record.com.mx/sites/default/files/styles/v2-crop768x433/public/articulos/2023/02/12/chiefs-eagles-3.jpg?itok=aqcBf3Xa',
    'https://cdn.racingnews365.com/2023/Verstappen/_1125x633_crop_center-center_85_none/XPB_1232299_HiRes.jpg?v=1693585040',
  ];

  return (
    <div className='w-screen h-screen bg-cblack'>
    <div>
      <nav className='bg-cgreenm flex justify-between py-6'>
        <ul className='flex'>
          <li>
            <a href="/home" className='font-bold ml-5 text-cwhite'>TournifyApp</a>
          </li>
          
        </ul>
        <ul className='text-cwhite font-bold'>
          <li>
            <a className='mr-8' >@TheMandalorian</a>
          </li>
        </ul>
      </nav>
    </div>
    <div className='overflow-hidden mt-3'>
    <Carousel
      plugins={[plugin.current]}
      className="w-full h-72 ml-1"
      onMouseEnter={plugin.current.stop}
      onMouseLeave={plugin.current.reset}
    >
      <CarouselContent className='h-72 w-full border-b-gray-700 '>
        {Array.from({ length: 5 }).map((_, index) => (
          <CarouselItem key={index} className='h-48 w-full'>
            <div>
              <Card className='h-72 w-full border-none'>
                <CardContent className="flex w-full h-72 aspect-square items-center justify-center bg-cblack ">
                  <img src={imageUrls[index]} alt={`Imagen ${index + 1}`} className="object-contain w-full h-full" />
                </CardContent>
              </Card>
            </div>
          </CarouselItem>
        ))}
      </CarouselContent>
      <CarouselPrevious />
      <CarouselNext />
    </Carousel>
    </div>

    <section className='bg-blue-600 grid gap-4 sm:grid-cols-5'>
          <div className='border-white border-2 flex'>
            Soccer
          </div>
          <div className='border-white border-2 flex'>
            Basket
          </div>
          <div className='border-white border-2 flex'>
            Tennis
          </div>
          <div className='border-white border-2 flex'>
            Football
          </div>
          <div className='border-white border-2 flex'>
            F1
          </div>
    </section>
    </div>
  )
}
