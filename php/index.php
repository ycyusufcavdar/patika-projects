<?php

function ucgenCiz($deger)
{
    for ($i=1; $i<$deger; $i++)
        {
            $s = 0;
            while($s <$i)
            {
                echo "0";
                $s++;

            }
            echo '<br>';

        }


}

ucgenCiz(20);