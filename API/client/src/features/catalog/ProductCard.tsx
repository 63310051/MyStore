import { Avatar, Button, Card, CardActions, CardContent, CardHeader, CardMedia, Typography } from "@mui/material";
import { Product } from "../../app/models/product";
import { Link } from "react-router-dom";
import { LoadingButton } from '@mui/lab';
import { currencyFormat } from "../../app/util/util";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { addBasketItemAsync } from "../basket/basketSlice";

interface Props {
    product: Product;
}

export default function ProductCard({product}: Props){
  const {status} = useAppSelector(state => state.basket);
  const dispatch = useAppDispatch();

    return (
    <Card>
      <CardHeader 
          avatar={
            <Avatar sx={{bgcolor: 'secondary.main'}}>
              {product.prod_name.charAt(0).toLocaleUpperCase()}
            </Avatar>
          }
          title={product.prod_name}
          titleTypographyProps={{
            sx: {fontWeight: 'bold', color: 'primary.main'}
          }}
      />
      <CardMedia
        sx={{ height: 140, backgroundSize: 'contain', bgcolor: 'primary.light' }}
        image={product.prod_pics}
        title={product.prod_name}
      />
      <CardContent>
        <Typography gutterBottom color='secondary' variant="h5">
          {currencyFormat(product.price)}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {product.brand} / {product.prod_type}
        </Typography>
      </CardContent>
      <CardActions>
        
        <LoadingButton
          loading={status.includes('pendingAddItem' + product.id)}
            onClick={()=> dispatch(addBasketItemAsync({productId: product.id}))}
            size="small">Add to cart</LoadingButton>
            
        <Button component={Link} to={`/catalog/${product.id}`} size="small">View</Button>
      </CardActions>
    </Card>
    )
}